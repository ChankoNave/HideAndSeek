using UnityEngine;
using Photon.Pun;
using UnityEngine.SceneManagement;
using System.IO;

public class RoomManager : MonoBehaviourPunCallbacks
{
	public static RoomManager inst;

	public void Awake()
	{
        if (inst)
        {
            Destroy(gameObject);
            return;
        }
        DontDestroyOnLoad(gameObject);
        inst = this;
		
	}

	public void DestroyGame()
    {
		Destroy(gameObject);
    }

	public override void OnEnable()
	{
		base.OnEnable();
		SceneManager.sceneLoaded += OnSceneLoaded;
	}

	public override void OnDisable()
	{
		base.OnDisable();
		SceneManager.sceneLoaded -= OnSceneLoaded;
	}

	private void OnSceneLoaded(Scene scene, LoadSceneMode loadSceneMode)
	{
		if(scene.buildIndex == GameMeaning.SCENEFIRST)
			PhotonNetwork.Instantiate(Path.Combine("PhotonPrefabs", "PlayerManager"), Vector3.zero, Quaternion.identity);
		Debug.Log("SDFse " + scene + " fds " + loadSceneMode);
	}
}