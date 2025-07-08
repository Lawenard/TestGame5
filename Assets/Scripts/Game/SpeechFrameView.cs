namespace Game
{
    using System;
    using Frames;
    using UnityEngine;

    public class SpeechFrameView : FrameView
    {
        public void View(SpeechFrame frame, Action<string> callback)
        {
            gameObject.SetActive(true);
            
            OnExit = callback;
        }
    }
}
