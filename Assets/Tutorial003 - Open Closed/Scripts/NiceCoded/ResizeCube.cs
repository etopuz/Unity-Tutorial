using UnityEngine;

public class ResizeCube : MonoBehaviour, IDamageable
{
    private const float MIN_SCALE = 0.5f;
    private const float MAX_SCALE = 2.0f;
    public void OnTakeDamage()
    {
        Resize();
    }

    private void Resize()
    {
        float scale = Random.Range(MIN_SCALE, MAX_SCALE);
        this.transform.localScale = Vector3.one * scale;
    }
}
