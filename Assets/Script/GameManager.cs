using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance { get; private set; }

    public GameObject gamePrefab;
    
    private GameObject currentGame;
    
    private void Awake()
    {
        if (Instance != null)
        {
            Debug.LogError("Cannot have mutiple instance of MenuManager");
        }
        Instance = this;
    }

    public void StartGame()
    {
        Debug.Log("Starting Game");
        Instantiate(gamePrefab);
    }
    
    public void EndGame()
    {
        Destroy(currentGame);
        currentGame = null;
    }
}
