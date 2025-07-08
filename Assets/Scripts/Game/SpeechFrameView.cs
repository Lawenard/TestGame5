namespace Game
{
    using System;
    using Frames;
    using TMPro;
    using UnityEngine;

    public class SpeechFrameView : FrameView<SpeechFrame>
    {
        [SerializeField] private TextMeshProUGUI text;

        public override void View(SpeechFrame frame, Action<string> callback)
        {
            base.View(frame, callback);
            
            text.text = frame.Text;
        }
    }
}
