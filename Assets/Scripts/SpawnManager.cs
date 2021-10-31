using UnityEngine;

public class SpawnManager : MonoBehaviour
{
	public static SpawnManager inst;

	SpawnpointHiding[] spawnpointHiding;
	SpawnpointManiac[] spawnpointsManiac;

	private void Awake()
	{
		inst = this;
		spawnpointHiding = GetComponentsInChildren<SpawnpointHiding>();
		spawnpointsManiac = GetComponentsInChildren<SpawnpointManiac>();
	}

	public Transform GetSpawnpointHiding() //2
	{
		return spawnpointHiding[Random.Range(0, spawnpointHiding.Length)].transform;
	}

    public Transform GetSpawnpointManiac() //1
    {
        return spawnpointsManiac[Random.Range(0, spawnpointsManiac.Length)].transform;
    }
}
