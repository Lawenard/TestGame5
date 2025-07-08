namespace Loader
{
    using System;

    [Serializable]
    public struct FrameWrapperRaw
    {
        public FrameRaw[] frames;
    }
    
    [Serializable]
    public struct FrameRaw
    {
        public string frameId;
        public string frameType;
        public string text;
        public string nextId;
        public string name;
        public string spriteId;
        public bool isRightSide;
        public ChoiceRaw[] choices;
        public string imageId;

        [Serializable]
        public struct ChoiceRaw
        {
            public string text;
            public string nextId;
        }
    }
}
