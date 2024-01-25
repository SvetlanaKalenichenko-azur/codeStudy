using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spikes : MonoBehaviour
{
    [SerializeField] private Player _player;
    private void OnCollisionEnter(Collision collision)
    {
        _player.TakeDamage(5);
    }

    
}
