using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 5f;
    private KeyCode lastKeyPressed;

    void Start()
    {
        
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            lastKeyPressed = KeyCode.W;
        }
        else if (Input.GetKeyDown(KeyCode.S))
        {
            lastKeyPressed = KeyCode.S;
        }
        else if (Input.GetKeyDown(KeyCode.A))
        {
            lastKeyPressed = KeyCode.A;
        }
        else if (Input.GetKeyDown(KeyCode.D))
        {
            lastKeyPressed = KeyCode.D;
        }

        if (Input.GetKey(lastKeyPressed))
        {
            switch (lastKeyPressed)
            {
                case KeyCode.W:
                    transform.Translate(Vector3.up * speed * Time.deltaTime);
                    break;
                case KeyCode.A:
                    transform.Translate(Vector3.left * speed * Time.deltaTime);
                    break;
                case KeyCode.S:
                    transform.Translate(Vector3.down * speed * Time.deltaTime);
                    break;
                case KeyCode.D:
                    transform.Translate(Vector3.right * speed * Time.deltaTime);
                    break;
            }
        }
    }
}
