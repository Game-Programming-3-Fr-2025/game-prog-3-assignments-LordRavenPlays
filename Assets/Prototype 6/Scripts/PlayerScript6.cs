using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
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

        if (Input.GetKey(KeyCode.UpArrow))
            vel.y = Speed;
        if (Input.GetKey(KeyCode.DownArrow))
            vel.y = -Speed;
        if (Input.GetKey(KeyCode.RightArrow))
            vel.x = Speed;
        if (Input.GetKey(KeyCode.LeftArrow))
            vel.x = -Speed;

        RB.linearVelocity = vel;
    }
}
