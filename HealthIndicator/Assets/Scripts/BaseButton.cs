using UnityEngine;
using UnityEngine.UI;

public abstract class BaseButton : MonoBehaviour
{
    [SerializeField] protected Health Health;
    [SerializeField] protected Button Button;
    [SerializeField] protected float Amount;

    private void OnEnable()
    {
        Button.onClick.AddListener(ChangeHealth);
    }

    private void OnDisable()
    {
        Button.onClick.RemoveListener(ChangeHealth);
    }

    public abstract void ChangeHealth();
}