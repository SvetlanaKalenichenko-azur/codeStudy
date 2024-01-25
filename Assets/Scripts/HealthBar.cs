using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    [SerializeField] private Player _player;
    [SerializeField] private Slider _slider;

    private void Awake()
    {
        _player.HealthChanged += OnHealthChanged;
    }

    private void OnHealthChanged(int health, int maxhealth)
    {
        _slider.value = (float)health / maxhealth;
    }
}
