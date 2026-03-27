using UnityEngine;
using UnityEngine.UI;

public abstract class BaseButton : MonoBehaviour
{
    [SerializeField] protected Health _health;
    [SerializeField] protected Button _button;

    protected float _amount;

    private void OnEnable()
    {
        _button.onClick.AddListener(ChangeHealth);
    }

    private void OnDisable()
    {
        _button.onClick.RemoveListener(ChangeHealth);
    }

    public abstract void ChangeHealth();
}