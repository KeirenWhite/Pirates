using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class DialogueSystem : MonoBehaviour
{
    public GameObject dialogueBox;
    public TMP_Text dialogueText;
    public string[] dialogueLines;
    private string[] currentDialogue;
    private int currentLine;
    private Transform npcTransform;

    void Start()
    {
        dialogueBox.SetActive(false);
        currentLine = 0;
    }
    
    public void StartDialogue(string[] dialogueLines, Transform npcTransform)
    {
        currentDialogue = dialogueLines;
        this.npcTransform = npcTransform;
        dialogueBox.SetActive(true);
        currentLine = 0;
        DisplayNextLine();
    }
    
    public void DisplayNextLine()
    {
        if(currentLine < currentDialogue.Length)
        {
            dialogueText.text = currentDialogue[currentLine];
            currentLine++;
        }
        else
        {
            EndDialogue();
        }
    }

    void EndDialogue()
    {
        dialogueBox.SetActive(false);
        currentLine = 0;
        npcTransform = null;
    }
    void Update()
    {
        if (npcTransform != null)
        {
            Vector3 aboveNPC = npcTransform.position + Vector3.up * 2f;
            dialogueBox.transform.position = aboveNPC;
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            DisplayNextLine();
        }
    }
}
