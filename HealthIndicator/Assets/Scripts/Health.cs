using System;
using UnityEngine;

public class Health : MonoBehaviour
{
    [SerializeField] private float _current;
    [SerializeField] private float _min = 0;
    [SerializeField] private float _max = 100;

    public float Current => _current;
    public float Max => _max;

    public event Action HealthChanged;

    private void Awake()
    {
        _current = _max;
    }

    public void TakeDamage(float damage)
    {
        _current -= damage;

        ProcessState();

        HealthChanged?.Invoke();
    }

    public void ApplyHeal(float amount)
    {
        _current += amount;

        if (_current >= _max)
            _current = _max;

        HealthChanged?.Invoke();
    }

    private void ProcessState()
    {
        if (_current <= _min)
        {
            _current = _min;
            return;
        }
    }
}