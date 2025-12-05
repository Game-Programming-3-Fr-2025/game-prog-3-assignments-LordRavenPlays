using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerScript4 : MonoBehaviour
{
    public Rigidbody2D RB;
    public float Speed = 5;
    Vector2 startPos = new Vector2();
    public GameObject FinishMarker;
    public GameObject Key;
    
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
        
        if (other.gameObject.CompareTag("EntityFinale"))
        {
            SceneManager.LoadScene("P4Hub");
        }

        if (other.gameObject.CompareTag("Finish1"))
        {
            SceneManager.LoadScene("P4Hub");
            GameInfo.BeatL1 = true;
        }
        
        if (other.gameObject.CompareTag("Finish2"))
        {
            SceneManager.LoadScene("P4Hub");
            GameInfo.BeatL2 = true;
        }
        
        if (other.gameObject.CompareTag("Finish3"))
        {
            SceneManager.LoadScene("P4Hub");
            GameInfo.BeatL3 = true;
        }
        
        if (other.gameObject.CompareTag("Finish"))
        {
            SceneManager.LoadScene("WinScene");
        }

        if (other.gameObject.CompareTag("Level1Portal"))
        {
            SceneManager.LoadScene("Level1");
        }
        
        if (other.gameObject.CompareTag("Level2Portal"))
        {
            SceneManager.LoadScene("Level2");
        }
        
        if (other.gameObject.CompareTag("Level3Portal"))
        {
            SceneManager.LoadScene("Level3");
        }
    }
}

public static class GameInfo
{
    public static bool BeatL1 = false;
    public static bool BeatL2 = false;
    public static bool BeatL3 = false;
}