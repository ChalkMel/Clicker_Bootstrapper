using System;
using _Source.Core;
using UnityEngine;

namespace _Source
{
  public class InputListener: MonoBehaviour
  {
    private Game _game;

    public void Init(Game game) => _game = game;
    private void Update()
    {
      if (Input.GetKeyDown(KeyCode.Escape))
      {
        _game.StopGame();
      }
    }
  }
}