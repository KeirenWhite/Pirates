using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdbeardInteraction : MonoBehaviour
{
    public DialogueSystem dialogueSystem;
    public TimeCycle timeCycle;
    public string[] npcDialogueLines;
    public float interactionDistance = 1.5f;
    private Transform player;
    public bool talkedToBird = false;

    void Start()
    {
        player = Camera.main.transform;
    }


    void Update()
    {
        if (timeCycle.currentHour >= 0)
        {
            if (Vector2.Distance(transform.position, player.position) < interactionDistance && Input.GetKeyDown(KeyCode.E))
            {
                dialogueSystem.StartDialogue(npcDialogueLines, transform);
                talkedToBird = true;
            }
        }

    }
}
