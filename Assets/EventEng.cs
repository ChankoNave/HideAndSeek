using UnityEngine;

public class EventEng : MonoBehaviour
{
    public static EventEng inst;

    private void Awake()
    {
        inst = this;
    }

    internal void DestroyGame()
    {
        Destroy(gameObject);
    }
}
