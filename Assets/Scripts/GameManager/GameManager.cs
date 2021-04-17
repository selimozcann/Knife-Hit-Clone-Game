using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    GameState _gameState;
    private void Start()
    {
        _gameState = GameState.Intro;
    }
    public enum GameState
    {
        Intro,
        Playing,
        Fail,
        Finish
    }
    public bool GamePlay()
    {
        return Input.GetMouseButton(0);
    }
}
