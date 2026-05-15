using UnityEngine;

public class PlayerScript5 : MonoBehaviour
{
    public Rigidbody2D RB;
    public Rigidbody2D point1;
    public Rigidbody2D point2;
    public Rigidbody2D point3;
    public Rigidbody2D point4;
    public Rigidbody2D point5;
    public Rigidbody2D point6;
    public Rigidbody2D point7;
    public Rigidbody2D point8;
    public Rigidbody2D point9;
    public Rigidbody2D point10;
    public Rigidbody2D point11;
    public Rigidbody2D point12;
    public Rigidbody2D point13;
    public Rigidbody2D point14;
    public Rigidbody2D point15;
    public Rigidbody2D point16;
    public Rigidbody2D point17;
    public Rigidbody2D point18;
    public float Speed = 5;
    public float SpeedDos = 5;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 vel = new Vector2(0, 0);
        Vector2 velDos = new Vector2(0, 0);

        if (Input.GetKey(KeyCode.RightArrow))
        {
            vel.x = Speed;
            velDos.y = SpeedDos;
        }    
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            vel.x = -Speed;
            velDos.y = -SpeedDos;
        }

        RB.linearVelocity = vel;
        point1.linearVelocity = velDos;
        point2.linearVelocity = velDos;
        point3.linearVelocity = velDos;
        point4.linearVelocity = velDos;
        point5.linearVelocity = velDos;
        point6.linearVelocity = velDos;
        point7.linearVelocity = velDos;
        point8.linearVelocity = velDos;
        point9.linearVelocity = velDos;
        point10.linearVelocity = velDos;
        point11.linearVelocity = velDos;
        point12.linearVelocity = velDos;
        point13.linearVelocity = velDos;
        point14.linearVelocity = velDos;
        point15.linearVelocity = velDos;
        point16.linearVelocity = velDos;
        point17.linearVelocity = velDos;
        point18.linearVelocity = velDos;

    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("TeleportLeft"))
        {
            Vector2 playerPos = new Vector2(-9, -2);
            RB.transform.position = playerPos;
        }

        if (other.gameObject.CompareTag("TeleportRight"))
        {
            Vector2 playerPos = new Vector2(9, -2);
            RB.transform.position = playerPos;
        }

        if (other.gameObject.CompareTag("Point"))
        {
            Destroy(other.gameObject);
        }
    }
}
