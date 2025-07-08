namespace Game
{
    using System.Collections.Generic;
    using Frames;
    using Loader;
    using UnityEngine;

    public class ChapterRunner : MonoBehaviour
    {
        [SerializeField] private TextAsset chapterFile;
        [SerializeField] private SpeechFrameView speechFrameView;
        [SerializeField] private TextFrameView textFrameView;
        [SerializeField] private ChoiceFrameView choiceFrameView;
        [SerializeField] private EndFrameView endFrameView;

        private List<Frame> frames;
        private int currentListId = 0;

        private void Start()
        {
            frames = StoryLoader.Load(chapterFile.text);
            
            ViewFrame(currentListId);
        }

        private void ViewFrame(string id = null)
        {
            int listId = currentListId;
            
            if (id == null) listId++;
            else listId = frames.IndexOf(frames.Find(f => f.Id == id));
            
            ViewFrame(listId);
        }
        
        private void ViewFrame(int listId)
        {
            currentListId = listId;
            
            Reset();
            
            switch (frames[listId])
            {
                case TextFrame textFrame:
                    textFrameView.View(textFrame, ViewFrame);
                    break;
                case SpeechFrame speechFrame:
                    speechFrameView.View(speechFrame, ViewFrame);
                    break;
                case ChoiceFrame choiceFrame:
                    choiceFrameView.View(choiceFrame, ViewFrame);
                    break;
                case EndFrame endFrame:
                    endFrameView.View(endFrame, _ => Application.Quit());
                    break;
            }
        }

        private void Reset()
        {
            textFrameView.Hide();
            speechFrameView.Hide();
            choiceFrameView.Hide();
            endFrameView.Hide();
        }
    }
}