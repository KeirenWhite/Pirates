using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPCinteraction : MonoBehaviour
{
    public DialogueSystem dialogueSystem;
    public string[] npcDialogueLines;
    public float interactionDistance = 1.5f;
    private Transform player;

    void Start()
    {
        player = Camera.main.transform; 
    }

    
    void Update()
    {
        if (Vector2.Distance(transform.position, player.position) < interactionDistance && Input.GetKeyDown(KeyCode.E))
        {
            dialogueSystem.StartDialogue(npcDialogueLines, transform);
        }    
    }
}
