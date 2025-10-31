using UnityEngine;

public class EnemyScript6 : MonoBehaviour
{
    public Transform _target;
    public float speed = 0.1f;

    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, _target.position, speed * Time.deltaTime);
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Box"))
        {
            Destroy(other.gameObject);
            speed = speed + 0.055f;
        }
    }
}
