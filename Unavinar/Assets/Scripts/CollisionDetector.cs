using UnityEngine;

public class CollisionDetector : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.layer == LayerMask.NameToLayer("Obstacles"))
            return;
        
        //De-parent object
        transform.parent = null;
        
        GetComponent<Rigidbody>().constraints = RigidbodyConstraints.None;
        Destroy(this);
    }
}
