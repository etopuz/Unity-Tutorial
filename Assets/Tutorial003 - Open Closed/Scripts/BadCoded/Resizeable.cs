using UnityEngine;
using Random = UnityEngine.Random;

public class Resizeable : MonoBehaviour
{
    private const float MIN_SCALE = 0.5f;
    private const float MAX_SCALE = 2.0f;

    public void ResizeOnAttack()
    {
        float scale = Random.Range(MIN_SCALE, MAX_SCALE);
        this.transform.localScale = Vector3.one * scale;
    }
}
