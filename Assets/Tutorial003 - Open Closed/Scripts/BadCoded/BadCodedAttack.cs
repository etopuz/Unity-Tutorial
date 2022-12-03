using UnityEngine;

public class BadCodedAttack : MonoBehaviour
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
            switch (hit.transform.tag)
            {
                case "DESTROYABLE":
                    hit.transform.GetComponent<Destroyable>().DestroyOnAttack();
                    break;
                
                case "RESIZEABLE":
                    hit.transform.GetComponent<Resizeable>().ResizeOnAttack();
                    break;
                
                case "COLOR_CHANGEABLE":
                    hit.transform.GetComponent<ColorChangeable>().ColorChangeOnAttack();
                    break;
            }
        }
    }
}
