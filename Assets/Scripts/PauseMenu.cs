using UnityEngine;
using UnityEngine.SceneManagement;
using Photon.Pun;

public class PauseMenu : MonoBehaviourPunCallbacks
{
    public static PauseMenu inst;

    [SerializeField]
    GameObject pausePanel, settinsPanel, shopPanels;

    PlayerController playerController;

    PhotonView PV;

    private void Awake()
    {
        inst = this;
        playerController = FindObjectOfType<PlayerController>();
        PV = FindObjectOfType<PhotonView>();
    }

    public void Continue()
    {
        SoundManager.inst.PlayButton();
        LevelController.inst?.ContinueGame();
        pausePanel.SetActive(false);
    }

    public void Menu()
    {
        BGMusic.inst.DestroyGame();
        RoomManager.inst.DestroyGame();
        //TODO Qiut to Menu//
        SceneManager.LoadScene(0);
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
