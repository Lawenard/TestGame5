namespace Game
{
    using System;
    using Frames;
    using UnityEngine;

    public class EndFrameView : FrameView
    {
        public void View(EndFrame frame, Action<string> callback)
        {
            gameObject.SetActive(true);
            
            OnExit = callback;
        }
    }
}
