using UnityEngine;

public class PlayerScript5 : MonoBehaviour
{
    public Rigidbody2D RB;
    public float Speed = 5;
    

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
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
