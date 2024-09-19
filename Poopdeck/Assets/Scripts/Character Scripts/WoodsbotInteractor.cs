using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WoodsbotInteractor : MonoBehaviour
{
    public DialogueSystem dialogueSystem;
    public TimeCycle timeCycle;
    public BirdbeardInteraction birdbeardInteraction;
    public string[] npcDialogueLines;
    public string[] npcDialogueLines2;
    public float interactionDistance = 1.5f;
    private Transform player;

    void Start()
    {
        player = Camera.main.transform;
    }


    void Update()
    {
        if (timeCycle.currentHour >= 0 && birdbeardInteraction.talkedToBird == true)
        {
            if (Vector2.Distance(transform.position, player.position) < interactionDistance && Input.GetKeyDown(KeyCode.E))
            {
                dialogueSystem.StartDialogue(npcDialogueLines2, transform);
            }
        }
            else if (timeCycle.currentHour >= 0 && !birdbeardInteraction.talkedToBird == true)
        {
            if (Vector2.Distance(transform.position, player.position) < interactionDistance && Input.GetKeyDown(KeyCode.E))
            {
                dialogueSystem.StartDialogue(npcDialogueLines, transform);
            }
        }

    }
}
