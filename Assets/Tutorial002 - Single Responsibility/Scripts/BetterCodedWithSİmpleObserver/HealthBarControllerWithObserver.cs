using UnityEngine.UI;
using UnityEngine;

public class HealthBarControllerWithObserver : MonoBehaviour
{
    [SerializeField] private Slider healthBarSlider;
    private BasePlayerWithObserver _basePlayerWithObserver;

    private void Awake()
    {
        _basePlayerWithObserver = GetComponent<BasePlayerWithObserver>();
    }

    private void UpdateHealthBar(int currentHealth, int startHealth)
    {
        float healthPercentage = (float)currentHealth / startHealth;
        healthBarSlider.value = healthPercentage;
        
        // canın oranına göre barın rengi yeşilden kırmızıya ilerleyebilir.
    }

    public void OnEnable()
    {
        _basePlayerWithObserver.OnTakeDamage += UpdateHealthBar;
    }
    
    public void OnDisable()
    {
        _basePlayerWithObserver.OnTakeDamage -= UpdateHealthBar;
    }
}
