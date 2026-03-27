using System;
using UnityEngine;

public class Health : MonoBehaviour
{
    [SerializeField] private float _currentHealth;
    [SerializeField] private float _minHealth = 0;
    [SerializeField] private float _maxHealth = 100;

    public float CurrentHealth => _currentHealth;
    public float MaxHealth => _maxHealth;

    private void Start()
    {
        _currentHealth = _maxHealth;
    }

    public void TakeDamage(float damage)
    {
        _currentHealth -= damage;

        ProcessState();
    }

    private void ProcessState()
    {
        if (_currentHealth <= _minHealth)
        {
            _currentHealth = _minHealth;
            return;
        }
    }

    public void Heal(float amount)
    {
        _currentHealth += amount;

        if (_currentHealth >= _maxHealth)
            _currentHealth = _maxHealth;
    }
}