using ScoreSystem;
using TMPro;
using UnityEngine;

namespace _Source.ScoreSystem
{
  public class ScoreView : MonoBehaviour
  {
    [SerializeField] private TextMeshProUGUI targetText;

    private Score _score;

    public void Init(Score score)
    {
      _score = score;
      _score.OnValueChanged += DrawScore;
      DrawScore();
    }

    private void OnDestroy()
    {
      _score.OnValueChanged -= DrawScore;
    }

    private void DrawScore()
    {
      targetText.text = $"Score: {_score.Value}";
    }
  }
}