namespace Frames
{
    using System;

    [Serializable]
    public class ChoiceFrame : Frame
    {
        public Choice[] Choices { get; init; }
    }

    [Serializable]
    public class Choice
    {
        public string NextId { get; init; }
        public string Text { get; init; }
    }
}
