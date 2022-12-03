using UnityEngine;

public class NiceCodedAttack : MonoBehaviour
{
    private Camera _camera;

    private void Start()
    {
        _camera = Camera.main;
    }

    void FixedUpdate()
    {
        if (Input.GetMouseButton(0))
        {
            Attack();
        }
    }

    private void Attack()
    {
        Ray ray = _camera.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;

        if (Physics.Raycast(ray, out hit))
        {
            if (hit.transform.TryGetComponent<IDamageable>(out IDamageable iDamageable))
            {
                iDamageable.OnTakeDamage();
            }
        }
    }
}
