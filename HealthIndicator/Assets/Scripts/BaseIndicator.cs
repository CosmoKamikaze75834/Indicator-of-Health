using UnityEngine;

public class BaseIndicator : MonoBehaviour
{
    [SerializeField] protected Health Health;

    protected float Fullness;

    private void OnEnable()
    {
        Health.HealthChanged += UpdateValue;
    }

    private void OnDisable()
    {
        Health.HealthChanged -= UpdateValue;
    }

    public virtual void UpdateValue()
    {
        Fullness = Health.Current / Health.Max;
    }
}