namespace Game
{
    using System;
    using Frames;
    using Loader;
    using TMPro;
    using UnityEngine;
    using UnityEngine.UI;

    public class EndFrameView : FrameView<EndFrame>
    {
        [SerializeField] private TextMeshProUGUI text;
        [SerializeField] private Image image;

        public override void View(EndFrame frame, Action<string> callback)
        {
            base.View(frame, callback);
            
            text.text = frame.Text;
            image.sprite = ImageLoader.LoadEndingImage(frame.ImageId);
        }
    }
}
