using UnityEngine.UI;
using UnityEngine;
public class HealthBarController : MonoBehaviour
{
    [SerializeField] private Slider healthBarSlider;

    public void UpdateHealthBar(int currentHealth, int startHealth)
    {
        float healthPercentage = (float)currentHealth / startHealth;
        healthBarSlider.value = healthPercentage;
        
        // canın oranına göre barın rengi yeşilden kırmızıya ilerleyebilir.
    }
    
}
