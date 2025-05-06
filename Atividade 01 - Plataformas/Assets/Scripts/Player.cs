using System;
using UnityEngine;
using UnityEngine.InputSystem;

public class Player : MonoBehaviour
{
    public float speed = 5f;

    private Rigidbody2D rig;
    
    public int moedas = 0;

    private void Start()
    {
        rig = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        Move();
        if (Keyboard.current.mKey.wasPressedThisFrame)
        {
            moedas++;
            PlayerObserverManager.ChangedMoedas(moedas);
        }
        
    }

    void Move()
    {
        rig.linearVelocity = new Vector2(Input.GetAxis("Horizontal") * speed, rig.linearVelocity.y);
        
    }
}
