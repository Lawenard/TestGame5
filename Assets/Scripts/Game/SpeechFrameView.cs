namespace Game
{
    using System;
    using Frames;
    using Loader;
    using TMPro;
    using UnityEngine;
    using UnityEngine.UI;

    public class SpeechFrameView : FrameView<SpeechFrame>
    {
        [SerializeField] private TextMeshProUGUI speechText;
        [SerializeField] private TextMeshProUGUI nameText;
        [SerializeField] private Image characterImage;
        [SerializeField] private Transform leftCharacterRoot;
        [SerializeField] private Transform rightCharacterRoot;
        [SerializeField] private Button nextButton;
        
        public override void View(SpeechFrame frame, Action<string> callback)
        {
            base.View(frame, callback);
            
            speechText.text = frame.Text;
            
            nameText.text = frame.Name;
            nameText.alignment = frame.IsRightSide ? TextAlignmentOptions.TopRight : TextAlignmentOptions.TopLeft;

            characterImage.sprite = ImageLoader.LoadCharacterImage(frame.Name, frame.SpriteId);
            characterImage.rectTransform.SetParent(frame.IsRightSide ? rightCharacterRoot : leftCharacterRoot);
            characterImage.rectTransform.anchoredPosition = Vector2.zero;
            
            nextButton.onClick.RemoveAllListeners();
            nextButton.onClick.AddListener(() => OnExit?.Invoke(frame.NextId));
        }
    }
}
