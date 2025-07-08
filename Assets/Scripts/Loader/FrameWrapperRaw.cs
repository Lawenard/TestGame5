namespace Loader
{
    using System;
    using Frames;

    [Serializable]
    public class FrameWrapperRaw
    {
        public FrameRaw[] frames;
    }
    
    [Serializable]
    public class FrameRaw
    {
        public string frameId;
        public string frameType;
        public string text;
        public string nextId;
        public string name;
        public string spriteId;
        public bool isRightSide;
        public Choice[] choices;
        public string imageId;
    }
}
