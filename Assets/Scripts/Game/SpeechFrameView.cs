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
        
        public override void View(SpeechFrame frame, Action<string> callback)
        {
            base.View(frame, callback);
            
            speechText.text = frame.Text;
            
            nameText.text = frame.Name;
            nameText.alignment = frame.IsRightSide ? TextAlignmentOptions.Right : TextAlignmentOptions.Left;

            characterImage.sprite = CharacterLoader.Load(frame.Name, frame.SpriteId);
            characterImage.rectTransform.parent = frame.IsRightSide ? rightCharacterRoot : leftCharacterRoot;
            characterImage.rectTransform.anchoredPosition = Vector2.zero;
        }
    }
}
