using UnityEngine;

public class MovementController : MonoBehaviour
{
    private float _speed = 6.0f;
    private PlayerInput _playerInput;

    private void Start()
    {
        _playerInput = GetComponent<PlayerInput>();
    }

    private void Update()
    {
        MovePlayer();
    }

    private void MovePlayer()
    {
        Vector3 moveVector = new Vector3(_playerInput.MovementHorizontal, _playerInput.MovementVertical, 0f) 
                             * (_speed * Time.deltaTime);
        transform.position += moveVector;
    }
}
