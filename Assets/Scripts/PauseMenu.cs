using UnityEngine;
using UnityEngine.SceneManagement;
using Photon.Pun;
using System.Threading.Tasks;
using Photon.Realtime;

public class PauseMenu : MonoBehaviour
{
    public static PauseMenu inst;

    [SerializeField]
    GameObject pausePanel, settinsPanel, shopPanels;
    new PhotonView photonView;

    private void Awake()
    {
        inst = this;
        photonView = GetComponent<PhotonView>();
    }

    public void Continue()
    {
        SoundManager.inst.PlayButton();
        LevelController.inst?.ContinueGame();
        pausePanel.SetActive(false);
    }

    public void Menu() 
    {
        PlayerController.inst.DisablePlayer();
        PlayerManager.inst.DisconnectController();
        SceneManager.LoadScene(2);
    }

    public void OpenSettings()
    {
        settinsPanel.SetActive(true);
        SoundManager.inst.PlayButton();
    }

    public void CloseSettings()
    {
        settinsPanel.SetActive(false);
        SoundManager.inst.PlayButton();
    }

    public void ShopSkins()
    {
        shopPanels.SetActive(true);
        SoundManager.inst.PlayButton();
    }

    public void QuitApp()
    {
        Application.Quit();
    }
}
