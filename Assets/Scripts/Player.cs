using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Player : MonoBehaviour
{
    private int _health = 15;
    private int _maxHealth = 100;

    public event UnityAction<int, int> HealthChanged;

    public void TakeDamage(int damage)
    {
        _health -= damage;
        _health = Mathf.Clamp(_health, 0, _maxHealth);

        HealthChanged?.Invoke(_health, _maxHealth);
    }
}
