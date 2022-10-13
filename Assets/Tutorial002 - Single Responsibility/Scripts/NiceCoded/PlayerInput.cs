using UnityEngine;

public class PlayerInput : MonoBehaviour
{
    private float _movementHorizontal;
    private float _movementVertical;
    
    public float MovementHorizontal => _movementHorizontal; 
    public float MovementVertical => _movementVertical;

    private void Update()
    {
        _movementHorizontal = Input.GetAxis("Horizontal");
        _movementVertical = Input.GetAxis("Vertical");
    }
    
}