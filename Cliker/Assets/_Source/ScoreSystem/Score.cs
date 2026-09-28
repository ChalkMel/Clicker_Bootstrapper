namespace ScoreSystem
{
  public class Score
  {
    public System.Action OnValueChanged;

    private int _value;
    public int Value => _value;

    public void SetValue(int value)
    {
      if (_value == value) return;
      _value = value;
      OnValueChanged?.Invoke();
    }

    public void Add(int delta) => SetValue(_value + delta);
  }
}