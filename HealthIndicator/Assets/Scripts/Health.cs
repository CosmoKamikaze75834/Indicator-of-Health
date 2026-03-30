using System;
using UnityEngine;

public class Health : MonoBehaviour
{
    [SerializeField] private float _min = 0;

    [SerializeField] public float Current { get; private set; }
    [SerializeField] public float Max { get; private set; } = 100;

    public event Action HealthChanged;

    private void Awake()
    {
        Current = Max;
    }

    public void Reduce(float damage)
    {
        Current -= damage;

        ProcessStateValidate();

        HealthChanged?.Invoke();
    }

    public void Increase(float amount)
    {
        Current += amount;

        if (Current >= Max)
            Current = Max;

        HealthChanged?.Invoke();
    }

    private void ProcessStateValidate()
    {
        if (Current <= _min)
        {
            Current = _min;
            return;
        }
    }
}