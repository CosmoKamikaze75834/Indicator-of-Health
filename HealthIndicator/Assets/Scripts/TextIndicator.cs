using TMPro;
using UnityEngine;

public class TextIndicator : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _text;
    [SerializeField] private Health _health;

    private string _symbol = "/";

    private void Update()
    {
        _text.text = _health.CurrentHealth + _symbol + _health.MaxHealth;
    }
}