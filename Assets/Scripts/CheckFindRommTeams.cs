using UnityEngine;
using UnityEngine.UI;

public class CheckFindRommTeams : MonoBehaviour
{
    public static CheckFindRommTeams inst;

    [SerializeField]
    GameObject panelTeams;

    [SerializeField]
    Button connectButton;

    private void Awake()
    {
        inst = this;
    }

    private void Start()
    {
        connectButton.onClick.AddListener(ConnectGame);
    }

    public void OnClickCheckTeams()
    {
        panelTeams.SetActive(true);
    }

    private void ConnectGame()
    {
        panelTeams.SetActive(false);
    }
}
