using System.Collections.Generic;
using Frames;
using UnityEngine;

namespace Loader
{
    using System.Linq;

    public static class StoryLoader
    {
        public static List<Frame> Load(string json)
        {
            FrameWrapperRaw wrapper = JsonUtility.FromJson<FrameWrapperRaw>(json);
            var frames = new List<Frame>();
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
                        var opts = new List<Choice>();
                        if (raw.choices != null) opts.AddRange(raw.choices.Select(c => new Choice
                        {
                            Text = c.text, NextId = c.nextId
                        }));
                        frames.Add(new ChoiceFrame
                        {
                            Id = raw.frameId, Text = raw.text, Choices = opts.ToArray()
                        });
                        break;
                    case "End":
                        frames.Add(new EndFrame
                        {
                            Id = raw.frameId, Text = raw.text, ImageId = raw.imageId
                        });
                        break;
                }
            }

            return frames;
        }
    }
}
