using System.Collections;
using System.Collections.Generic;
using Unity.AppUI.UI;
using UnityEngine;
using UnityEngine.UI;

public class PlayerScriptP2 : MonoBehaviour
{

    public GameObject Text;
    public GameObject Player;
    public Rigidbody2D RB;
    public float Speed = 5;
    Vector2 startPos = new Vector2();
    public bool fallDamage = false;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Vector3 startPos = transform.position;
        this.startPos = startPos;
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 vel = new Vector2(0, 0);

        if (Input.GetKey(KeyCode.RightArrow))
            vel.x = Speed;
        if (Input.GetKey(KeyCode.LeftArrow))
            vel.x = -Speed;

        RB.linearVelocity = vel;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            if (fallDamage == true)
            {
                Player.transform.position = startPos;
            }
            else
            {
                Text.SetActive(true);
            }
        }

        if (collision.gameObject.CompareTag("Point"))
        {
            Renderer rend = Player.GetComponent<Renderer>();
            if (fallDamage == true)
            {
                fallDamage = false;
                rend.material.color = Color.blue;
            }

            else if (!fallDamage)
            {
                fallDamage = true;
                rend.material.color = Color.yellow;
            }
        }
    }
}
