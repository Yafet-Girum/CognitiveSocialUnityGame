
using UnityEngine;
using UnityEngine.UI;

public class SocialNarrative : MonoBehaviour
{
    public Text dialogueText;
    public Button[] choiceButtons;

    void Start()
    {
        DisplayDialogue("Welcome to the story game!");
    }

    public void DisplayDialogue(string text)
    {
        dialogueText.text = text;
    }

    public void MakeChoice(int choiceIndex)
    {
        // Logic for handling player choices and branching outcomes
    }
}
