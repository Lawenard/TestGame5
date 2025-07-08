namespace Game
{
    using System;
    using Frames;
    using TMPro;
    using UnityEngine;

    public class TextFrameView : FrameView<TextFrame>
    {
        [SerializeField] private TextMeshProUGUI text;
        
        public override void View(TextFrame frame, Action<string> callback)
        {
            base.View(frame, callback);
            
            text.text = frame.Text;
        }
    }
}
