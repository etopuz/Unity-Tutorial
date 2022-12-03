using UnityEngine;

public class ChangeColorOfCube : MonoBehaviour, IDamageable
{
    private Renderer _renderer;

    private void Start()
    
    {
        _renderer = GetComponent<Renderer>();
    }
    private void ChangeColor()
    {
        Color randomColor = new Color(Random.Range(0f, 1f), Random.Range(0f, 1f), Random.Range(0f, 1f), 1f);
        _renderer.material.SetColor("_Color", randomColor);
    }

    public void OnTakeDamage()
    {
        ChangeColor();
    }
}
