using Photon.Pun;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    public static PauseMenu inst;

    [SerializeField] GameObject pausePanel, settinsPanel, shopPanels;

    PlayerController playerController;
    private void Awake()
    {
        inst = this;
        playerController = FindObjectOfType<PlayerController>();
    }

    public void Continue()
    {
        SoundManager.inst.PlayButton();
        LevelController.inst?.ContinueGame();
        pausePanel.SetActive(false);
    }

    public void Menu() // TODO Допилить!!
    {
        Destroy(playerController);
        SceneManager.LoadScene(GameMeaning.MENU);
        
    }

    //public void OnMenu(Menu menu)
    //{
    //    menu.Open();
    //}

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

    void OnLeftRoom()
    {
        PhotonNetwork.LoadLevel(2);
    }

    public void QuitApp()
    {
        Application.Quit();
        Debug.Log("Exit");
    }
}
