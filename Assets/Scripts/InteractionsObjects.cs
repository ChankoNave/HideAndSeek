using UnityEngine;

public class InteractionsObjects : MonoBehaviour
{
    private int weaponThis;

    private void Start()
    {
        RandomWeapons();
    }

    private void RandomWeapons()
    {
        weaponThis = Random.Range(0, 8);
    }

    private void OnCollisionEnter(Collision collision)//OnTriggerEnter(Collider other)
    {
        if (collision.gameObject.tag == "Player")
            collision.gameObject.GetComponent<PlayerController>().InteractionsOn(weaponThis);
    }

    public void OpenObject()
    {
        SoundManager.inst.FindWeapons();
        Destroy(gameObject, GameMeaning.destroyGameInteractions);
    }
}
