using System.Collections.Generic;
using Frames;
using UnityEngine;

namespace Loader
{
    using System;
    using System.Linq;

    public static class StoryLoader
    {
        public static List<Frame> Load(string json)
        {
            FrameWrapperRaw wrapper = JsonUtility.FromJson<FrameWrapperRaw>(json);
            var frames = new List<Frame>();
            
            if (wrapper.frames == null || !wrapper.frames.Any())
                throw new Exception($"Unable to load story from JSON. ctx: {json}");
            
            foreach (FrameRaw raw in wrapper.frames)
            {
                switch (raw.frameType)
                {
                    case "Text":
                        frames.Add(new TextFrame
                        {
                            Id = raw.frameId, Text = raw.text, NextId = raw.nextId
                        });
                        break;
                    case "Speech":
                        frames.Add(new SpeechFrame
                        {
                            Id = raw.frameId, Name = raw.name, SpriteId = raw.spriteId, IsRightSide = raw.isRightSide,
                            Text = raw.text, NextId = raw.nextId
                        });
                        break;
                    case "Choice":
                        var choices = new List<Choice>();
                        if (raw.choices != null)
                        {
                            choices.AddRange(raw.choices.Select(c => new Choice
                            {
                                Text = c.text, NextId = c.nextId
                            }));
                        }
                        else throw new Exception($"Unable to load choices for frame id: {raw.frameId}");
                        frames.Add(new ChoiceFrame
                        {
                            Id = raw.frameId, Text = raw.text, Choices = choices.ToArray()
                        });
                        break;
                    case "End":
                        frames.Add(new EndFrame
                        {
                            Id = raw.frameId, Text = raw.text, ImageId = raw.imageId
                        });
                        break;
                    default:
                        throw new Exception($"Unknown frame type: {raw.frameType}");
                }
            }

            return frames;
        }
    }
}
