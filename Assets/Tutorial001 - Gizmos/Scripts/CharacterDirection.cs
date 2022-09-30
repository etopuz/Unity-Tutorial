using UnityEngine;

public class CharacterDirection : MonoBehaviour
{
    private Camera _mainCamera;
    private Vector3 _targetPosition;
    private Plane _rayPlane = new Plane(Vector3.forward, 0);
    private void Awake()
    {
        _mainCamera = Camera.main;
    }

    private void Update()
    {
        FindTargetPosition();
        transform.rotation = Quaternion.LookRotation(_targetPosition - transform.position);
    }

    private void FindTargetPosition()
    {
        Ray ray = _mainCamera.ScreenPointToRay(Input.mousePosition);
        if (_rayPlane.Raycast(ray, out float distance))
        {
            _targetPosition = ray.GetPoint(distance);
        }

    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawLine(transform.position, transform.position + transform.forward);
    }
}
