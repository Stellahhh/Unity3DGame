using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaveSpawner : MonoBehaviour
{
    public GameObject enemyPrefab;
    public float startTime;
    public float endTime;
    public float spawnRate;
    // Start is called before the first frame update
    private void Start()
    {
        // WavesManager.instance.waves.Add(this);
        WavesManager.instance.AddWave(this);
        InvokeRepeating("Spawn", startTime, spawnRate);
        Invoke("EndSpawning", endTime);

    }

    void Spawn()
    {
        Instantiate(enemyPrefab, transform.position, transform.rotation);
    }

    void EndSpawner()
    {
        // WavesManager.instance.waves.Remove(this);
        WavesManager.instance.RemoveWave(this);
        CancelInvoke();
    }
}
