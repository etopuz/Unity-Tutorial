using UnityEngine;

public class Destroyable : MonoBehaviour
{
    public void DestroyOnAttack()
    {
        Destroy(gameObject);
    }
}
