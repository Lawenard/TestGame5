namespace Frames
{
    public class ChoiceFrame : Frame
    {
        public Choice[] Choices { get; init; }
    }
    
    public class Choice
    {
        public string NextId { get; init; }
        public string Text { get; init; }
    }
}
