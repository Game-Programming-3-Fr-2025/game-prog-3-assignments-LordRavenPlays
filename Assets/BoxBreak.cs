using UnityEngine;

public class BoxBreak : MonoBehaviour
{
    public ParticleSystem sys;

    private void OnCollisionEnter2D()
    {
        sys.Play();
        Destroy(gameObject, 0.09f);
    }
}
