using TMPro;
using UnityEngine;

public class TextIndicator : BaseIndicator
{
    [SerializeField] private TextMeshProUGUI _text;

    private string _symbol = "/";

    private void Start()
    {
        UpdateValue();
    }

    public override void UpdateValue()
    {
        _text.text = Health.Current + _symbol + Health.Max;
    }
}