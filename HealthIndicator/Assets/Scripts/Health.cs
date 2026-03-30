using System;
using UnityEngine;

public class Health : MonoBehaviour
{
    [SerializeField] private float _min = 0;

    [field: SerializeField] public float Current { get; private set; }
    [field: SerializeField] public float Max { get; private set; } = 100;

    public event Action HealthChanged;

    private void Awake()
    {
        Current = Max;
    }

    public void Reduce(float damage)
    {
        Current -= damage;

        LimitValues();

        HealthChanged?.Invoke();
    }

    public void Increase(float amount)
    {
        Current += amount;

        LimitValues();

        HealthChanged?.Invoke();
    }

    private void LimitValues()
    {
        Current = Mathf.Clamp(Current, _min, Max);
    }
}