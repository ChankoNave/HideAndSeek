using UnityEngine;

public class Teleport : MonoBehaviour
{
    [SerializeField] GameObject teleport;

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            SoundManager.inst.TeleportOneSound();
            other.transform.position = teleport.transform.position;
        }
    }
}
