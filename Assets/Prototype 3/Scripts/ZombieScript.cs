using UnityEngine;

// uses code from https://www.bing.com/videos/riverview/relatedvideo?q=how+to+make+an+object+move+towards+another+object+in+unity&mid=871DD9395A46AC41752D871DD9395A46AC41752D&FORM=VIRE

public class ZombieScript : MonoBehaviour
{

    public Transform _target;
    public float _speed;

    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, _target.position, _speed * Time.deltaTime);
    }
}
