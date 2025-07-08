namespace Game
{
    using System;
    using Frames;
    using TMPro;
    using UnityEngine;

    public class EndFrameView : FrameView<EndFrame>
    {
        [SerializeField] private TextMeshProUGUI text;

        public override void View(EndFrame frame, Action<string> callback)
        {
            base.View(frame, callback);
            
            text.text = frame.Text;
        }
    }
}
