using UnityEngine;

public class Mine : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            collision.gameObject.GetComponent<Rigidbody>().AddForce(new Vector3(0, 1111, 0));
            // Add soung force
            Destroy(gameObject);
        }
    }
}