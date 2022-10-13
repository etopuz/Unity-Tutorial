using UnityEngine;

public class BasePlayer : MonoBehaviour
{
    [SerializeField] private int startHealth;
    
    private int _health = 100;
    private HealthBarController _healthBar;

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
        _healthBar.UpdateHealthBar(_health, startHealth);
    }

    private void Die()
    {
        _health = 0;
        Destroy(gameObject);
        // ölüm animasyonunu oynat, Play again butonu göster vs..
    }
}
