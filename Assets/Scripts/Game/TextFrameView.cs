namespace Game
{
    using System;
    using Frames;
    using TMPro;
    using UnityEngine;
    using UnityEngine.UI;

    public class TextFrameView : FrameView<TextFrame>
    {
        [SerializeField] private TextMeshProUGUI text;
        [SerializeField] private Button nextButton;
        
        public override void View(TextFrame frame, Action<string> callback)
        {
            base.View(frame, callback);
            
            text.text = frame.Text;
            
            nextButton.onClick.RemoveAllListeners();
            nextButton.onClick.AddListener(() => OnExit?.Invoke(frame.NextId));
        }
    }
}
