namespace Game
{
    using System;
    using System.Collections.Generic;
    using Frames;
    using TMPro;
    using UnityEngine;

    public class ChoiceFrameView : FrameView<ChoiceFrame>
    {
        [SerializeField] private TextMeshProUGUI text;
        [SerializeField] private ChoiceOptionView originalOptionView;

        private readonly List<ChoiceOptionView> optionViews = new();

        private void Awake()
        {
            optionViews.Add(originalOptionView);
        }

        public override void View(ChoiceFrame frame, Action<string> callback)
        {
            base.View(frame, callback);

            text.text = frame.Text;

            Reset();
            Populate(frame.Choices.Length - optionViews.Count);

            for (var i = 0; i < frame.Choices.Length; i++)
            {
                Choice choice = frame.Choices[i];
                optionViews[i].View(choice.Text, () => callback.Invoke(choice.NextId));
            }
        }

        private void Populate(int count)
        {
            for (var i = 0; i < count; i++)
                optionViews.Add(Instantiate(originalOptionView, originalOptionView.transform.parent));
        }

        private void Reset()
        {
            foreach (ChoiceOptionView optionView in optionViews)
                optionView.Hide();
        }
    }
}
