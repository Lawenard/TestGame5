namespace Game
{
    using System;
    using Frames;
    using UnityEngine;

    public class ChoiceFrameView : FrameView
    {
        public void View(ChoiceFrame frame, Action<string> callback)
        {
            gameObject.SetActive(true);
            
            OnExit = callback;
        }
    }
}
