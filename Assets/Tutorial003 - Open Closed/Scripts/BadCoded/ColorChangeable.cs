using UnityEngine;
using Random = UnityEngine.Random;

public class ColorChangeable : MonoBehaviour
{
    private Renderer _renderer;
    private void Start()
    {
        _renderer = GetComponent<Renderer>();
    }

    public void ColorChangeOnAttack()
    {
        Color randomColor = new Color(Random.Range(0f, 1f), Random.Range(0f, 1f), Random.Range(0f, 1f), 1f);
        _renderer.material.SetColor("_Color", randomColor);
    }
}
