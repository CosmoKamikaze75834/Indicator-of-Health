using TMPro;
using UnityEngine;

public class TextIndicator : BaseIndicator
{
    [SerializeField] private TextMeshProUGUI _text;

    private string _symbol = "/";

    private void Start()
    {
        UpdateValue(Health.Current, Health.Max);
    }

    protected override void UpdateValue(float current, float max)
    {
        _text.text = current + _symbol + max;
    }
}