using UnityEngine;
using UnityEngine.UI;

public abstract class BaseBar : MonoBehaviour
{
    [SerializeField] protected Slider _slider;
    [SerializeField] protected Health _health;

    protected float fullness;

    private void Start()
    {
        _slider.interactable = false;
    }

    private void Update()
    {
        UpdateValue();
    }

    public virtual void UpdateValue()
    {
        fullness = _health.CurrentHealth / _health.MaxHealth;
    }
}