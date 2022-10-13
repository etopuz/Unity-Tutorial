using UnityEngine;
using UnityEngine.UI;
public class BadGeneralPlayerClass : MonoBehaviour
{

    [Header("Movement")]
    private float _speed = 6.0f;
    
    [Header("Health")]
    [SerializeField] private int startHealth;
    [SerializeField] private Slider hpBarSlider;
    private int _currentHealth = 100;

    private void Start()
    {
        _currentHealth = startHealth;
    }

    private void Update()
    {
        MovePlayer();
    }

    private void MovePlayer()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 moveVector = new Vector3(moveHorizontal, moveVertical, 0f) * (_speed * Time.deltaTime);

        transform.position += moveVector;
    }

    public void TakeDamage(int damage)
    {
        _currentHealth -= damage;
        if (_currentHealth <= 0) // ölüm
        {
            _currentHealth = 0;
            Destroy(gameObject);
            //ölüm animasyonunu oynat, Play again butonu göster vs..
        }
        
        float healthPercentage = (float)_currentHealth / startHealth;
        hpBarSlider.value = healthPercentage;
    }
}