using NUnit.Framework.Constraints;
using System;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    //access anywhere
    public static GameManager Instance;
    //declaring the game state
    public GameState State;
    
    public static event Action<GameState> GameStateChanged;

    private void Awake()
    {
        
        Instance = this;

    }

    public void UpdateGameState(GameState newState)
    {

        State = newState;

        switch (newState)
        {

            case GameState.GenerateGrid:

                GridManager.Instance.GenerateGrid();

                break;

            case GameState.SpawnPlayer:
                break;

            case GameState.SpawnEnemies:
                break;

            case GameState.PlayerTurn:
                break;

            case GameState.EnemyTurn:
                break;

            default:

                throw new ArgumentOutOfRangeException(nameof(newState),newState, null);

        }

    }
    //state of the game
    public enum GameState
    {

        GenerateGrid = 0,
        SpawnPlayer = 1,
        SpawnEnemies = 2,
        PlayerTurn = 3,
        EnemyTurn = 4

    }

}
