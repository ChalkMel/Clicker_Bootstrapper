using _Source.ScoreSystem;
using ScoreSystem;
using UnityEngine;

namespace _Source.Core
{
  public class Game
  {
    private const int start_score = 5;

    private readonly Score _score;

    public Game(Score score)
    {
      _score = score;
      StartGame();
    }

    private void StartGame()
    {
      _score.SetValue(start_score);
    }

    public void StopGame()
    {
      _score.SetValue(0);
      Application.Quit();
    }
  }
}