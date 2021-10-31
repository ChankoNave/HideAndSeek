using System.Threading.Tasks;
using UnityEngine;

public class MatchController : MonoBehaviour
{

    private float gameTime, timer;

    PlayerController playerController;

    private void Awake()
    {
        TickerGame();
    }

    //private void Start()
    //{
    //    CheckPlayesIsScene();
    //}

    //private void CheckPlayesIsScene()
    //{
    //    playerController = FindObjectOfType<PlayerController>();

    //    if (playerController.TeamID == 1)
    //    {

    //    }
    //}


    private async void TickerGame()
    {
        gameTime = GameMeaning.TIMEGAME;

        //while (gameTime >= 1000)
        //{
        //    await Task.Delay(1000);
        //    gameTime -= 1000;
        //    timer = gameTime / 1000;
        //    Debug.Log("Timer " + timer);
        //    //ReactorEngineerUI.inst.ReactorCoolingTimerText.text = timeCooling.ToString();
        //}

        //ReactorManager.inst.reactor.CoolReactor();
        //ReactorEngineerUI.inst.OverheatingFinished();
    }


    // Timer

    // Team <=0 ?

    // Go to Lobby 
}
