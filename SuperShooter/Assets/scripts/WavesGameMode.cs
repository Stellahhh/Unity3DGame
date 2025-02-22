using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WavesGameMode : MonoBehaviour
{
    // public Life playerLife;
    [SerializeField] Life playerLife;
    [SerializeField] Life playerBaseLife;
    // void Awake()
    void Start()
    {
        // playerLife.onDeath.AddListener(OnPlayerDied);
        playerLife.onDeath.AddListener(OnPlayerOrBaseDied);
        playerBaseLife.onDeath.AddListener(OnPlayerOrBaseDied);
        EnemiesManager.instance.onChanged.AddListener(CheckWinCondition);
        WavesManager.instance.onChanged.AddListener(CheckWinCondition);

    }

    // Update is called once per frame
    // void Update()
    void CheckWinCondition()
    {
        if (EnemiesManager.instance.enemies.Count <= 0 &&
            WavesManager.instance.waves.Count <= 0)
        {
            SceneManager.LoadScene("WinScreen");
        }

        // if (playerLife.amount <= 0)
        // {
        //     SceneManager.LoadScene("LoseScreen");
        // }

    }

    // void OnPlayerDied()
    // {
    //     SceneManager.LoadScene("LoseScreen");
    // }
    void OnPlayerOrBaseDied()
    {
        SceneManager.LoadScene("LoseScreen");
    }
}
