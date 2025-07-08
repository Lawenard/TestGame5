namespace Game
{
    using System;
    using TMPro;
    using UnityEngine;
    using UnityEngine.UI;

    public class ChoiceOptionView : MonoBehaviour
    {
        [SerializeField] private TextMeshProUGUI optionText;
        [SerializeField] private Button button;

        public void View(string text, Action callback)
        {
            gameObject.SetActive(true);
            
            optionText.text = text;
            
            button.onClick.AddListener(callback.Invoke);
        }

        public void Hide()
        {
            gameObject.SetActive(false);
            
            button.onClick.RemoveAllListeners();
        }
    }
}
