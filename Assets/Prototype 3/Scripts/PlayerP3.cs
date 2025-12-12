using NUnit.Framework;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

//uses code from https://www.youtube.com/watch?v=4OQjnKUENoE

public class PlayerP3 : MonoBehaviour
{
    public Rigidbody2D RB;
    public float Speed = 5;

    public int numberToSpawn;
    public List<GameObject> spawnPool;
    public GameObject quad;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public void Start()
    {
        spawnObjects();
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

    public void spawnObjects()
    {
        int randomItem = 0;
        GameObject toSpawn;
        MeshCollider c = quad.GetComponent<MeshCollider>();

        float screenX, screenY;
        Vector2 pos;

        for (int i = 0; i < numberToSpawn; i++)
        {
            randomItem = Random.Range(0, spawnPool.Count);
            toSpawn = spawnPool[randomItem];

            screenX = Random.Range(c.bounds.min.x, c.bounds.max.x);
            screenY = Random.Range(c.bounds.min.y, c.bounds.max.y);
            pos = new Vector2(screenX, screenY);

            Instantiate(toSpawn, pos, toSpawn.transform.rotation);
        }
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Point"))
        {
            Destroy(other.gameObject);
            spawnObjects();
        }

        if (other.gameObject.CompareTag("Zombie"))
        {
            SceneManager.LoadScene("LoseScene");
        }
    }
}
