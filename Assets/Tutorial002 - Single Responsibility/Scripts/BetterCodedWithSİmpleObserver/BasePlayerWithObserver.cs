using System;
using UnityEngine;

public class BasePlayerWithObserver : MonoBehaviour
{
    [SerializeField] private int startHealth;
    
    private int _health = 100;
    private HealthBarController _healthBar;

    public event Action<int,int> OnTakeDamage; //  

    private void Start()
    {
        _health = startHealth;
        _healthBar = GetComponent<HealthBarController>();
    }

    public void TakeDamage(int damage)
    {
        _health -= damage;
        if (_health <= 0) // ölüm
        {
            Die();
        }
        OnTakeDamage?.Invoke(_health, startHealth);
    }

    private void Die()
    {
        _health = 0;
        Destroy(gameObject);
        // ölüm animasyonunu oynat, Play again butonu göster vs..
    }
}
