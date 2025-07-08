namespace Game
{
    using System;
    using UnityEngine;

    public class FrameView : MonoBehaviour
    {
        protected Action<string> OnExit;
        
        public void Hide() => gameObject.SetActive(false);
    }
}
