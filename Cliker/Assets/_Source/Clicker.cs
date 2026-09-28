using UnityEngine;
using _Source.ScoreSystem;
using ScoreSystem;

namespace _Source
{
  public class Clicker : MonoBehaviour
  {
    [SerializeField] private int scoreDelta;

    private Score _score;

    public void Init(Score score) => _score = score;

    private void OnMouseDown()
    {
      _score?.Add(scoreDelta);
    }
  }
}