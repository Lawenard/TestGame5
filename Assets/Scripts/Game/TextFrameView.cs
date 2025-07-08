namespace Game
{
    using System;
    using Frames;
    using TMPro;
    using UnityEngine;

    public class TextFrameView : FrameView
    {
        [SerializeField] private TextMeshProUGUI text;
        
        public void View(TextFrame frame, Action<string> callback)
        {
            gameObject.SetActive(true);
            
            OnExit = callback;
            
            text.text = frame.Text;
        }
    }
}
