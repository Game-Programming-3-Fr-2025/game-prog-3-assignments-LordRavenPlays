using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerScript4 : MonoBehaviour
{
    public Rigidbody2D RB;
    public float Speed = 5;
    Vector2 startPos = new Vector2();
    public GameObject FinishMarker;
    public GameObject Key;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Vector3 startPos = transform.position;
        this.startPos = startPos;
    }

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

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Box"))
        {
            Destroy(other.gameObject);
            RB.transform.position = startPos;
        }

        if (other.gameObject.CompareTag("Key"))
        {
            FinishMarker.SetActive(true);
            Destroy(other.gameObject);
        }
        
        if (other.gameObject.CompareTag("Pre-Key"))
        {
            Key.SetActive(true);
            Destroy(other.gameObject);
        }

        if (other.gameObject.CompareTag("Entity"))
        {
            SceneManager.LoadScene("P4Hub");
        }

        if (other.gameObject.CompareTag("Finish"))
        {
            SceneManager.LoadScene("P4Hub");
        }

        if (other.gameObject.CompareTag("Level1Portal"))
        {
            SceneManager.LoadScene("Level1");
        }
        
        if (other.gameObject.CompareTag("Level2Portal"))
        {
            SceneManager.LoadScene("Level2");
        }
    }
}