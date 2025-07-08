namespace Game
{
    using System;
    using Frames;
    using UnityEngine;

    public abstract class FrameView<T> : MonoBehaviour where T : Frame
    {
        protected Action<string> OnExit { get; private set; }
        
        public virtual void View(T frame, Action<string> callback)
        {
            gameObject.SetActive(true);
            
            OnExit = callback;
        }
        
        public void Hide() => gameObject.SetActive(false);
    }
}
