using UnityEngine;

public class DestroyCube : MonoBehaviour, IDamageable
{
    public void OnTakeDamage()
    {
        Destroy(gameObject);
    }
}
