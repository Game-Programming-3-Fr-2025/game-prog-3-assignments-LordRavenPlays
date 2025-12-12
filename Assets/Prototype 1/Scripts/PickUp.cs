using UnityEngine;

//Uses code from https://www.youtube.com/watch?v=-V1O5FGQVY8&t=7s

public class PickUp : MonoBehaviour
{
    public Transform holdSpot;
    public float holdSpotRadius = .4f;
    public LayerMask pickUpMask;

    public Vector3 Direction { get; set; }
    private GameObject itemHolding;

    private bool isPlayerHoldingObject = false;


    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.J))
        {
            if (isPlayerHoldingObject == false)
            {
                Collider2D pickUpItem = Physics2D.OverlapCircle(transform.position, holdSpotRadius, pickUpMask);

                if (pickUpItem != null)
                {
                    itemHolding = pickUpItem.gameObject;
                    itemHolding.transform.position = holdSpot.position;
                    itemHolding.GetComponent<Rigidbody2D>().simulated = false;
                }

                isPlayerHoldingObject = true;
            } 
        }   
        
        if (Input.GetKeyDown(KeyCode.K))
        {
            isPlayerHoldingObject = false;
            itemHolding.GetComponent<Rigidbody2D>().simulated = true;
        }

        if(isPlayerHoldingObject == true)
        {
            itemHolding.transform.position = holdSpot.position;
        }
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(holdSpot.position, holdSpotRadius);
    }
}
