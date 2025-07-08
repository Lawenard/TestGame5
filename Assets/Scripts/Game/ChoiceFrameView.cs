namespace Game
{
    using System;
    using Frames;
    using TMPro;
    using UnityEngine;

    public class ChoiceFrameView : FrameView<ChoiceFrame>
    {
        [SerializeField] private TextMeshProUGUI text;
        
        public override void View(ChoiceFrame frame, Action<string> callback)
        {
            base.View(frame, callback);
            
            text.text = frame.Text;
        }
    }
}
