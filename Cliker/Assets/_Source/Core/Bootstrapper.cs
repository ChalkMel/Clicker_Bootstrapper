using _Source;
using _Source.Core;
using _Source.ScoreSystem;
using ScoreSystem;
using UnityEngine;

namespace Core
{
  public class Bootstrapper : MonoBehaviour
  {
    [SerializeField] private InputListener inputListener;
    [SerializeField] private Clicker clickerIncrement;
    [SerializeField] private Clicker clickerDecrement;
    [SerializeField] private ScoreView scoreView;

    private Score _score;
    private Game _game;

    private void Awake()
    {
      _score = new Score();

      clickerIncrement.Init(_score);
      clickerDecrement.Init(_score);
      scoreView.Init(_score);

      _game = new Game(_score);
      inputListener.Init(_game);
    }
  }
}