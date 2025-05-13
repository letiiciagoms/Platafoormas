using System;
using UnityEngine;
using UnityEngine.InputSystem;

public class SimplePlayer : MonoBehaviour
{
    public int moedas = 0;

    public CommandManager MyCommandManager;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        MyCommandManager = new CommandManager();
    }

    // Update is called once per frame
    void Update()
    {
        if (Keyboard.current.wKey.wasPressedThisFrame)
        {
            MyCommandManager.AddCommand(new MoveUp(transform));
            MyCommandManager.DoCommand();
            //transform.position += Vector3.up;
        }
        if (Keyboard.current.dKey.wasPressedThisFrame)
        {
            transform.position += Vector3.right;
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Coin"))
        {
            moedas++;
            Destroy(other.gameObject);
        }
    }
}
