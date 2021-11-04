using UnityEngine;
using UnityEngine.SceneManagement;

public class NewScene2 : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Debug.Log("New  Scenes -2 ");
            SceneManager.LoadScene(3);
        }
    }
}
