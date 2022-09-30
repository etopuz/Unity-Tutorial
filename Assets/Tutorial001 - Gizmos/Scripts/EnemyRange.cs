using UnityEngine;

public class EnemyRange : MonoBehaviour
{
    [SerializeField] 
    private float detectionRange;

    [SerializeField] 
    private Transform player;

    private Color _detectionColor;


    private void Update()
    {
        bool isInRange = Vector3.Distance(player.position, transform.position) <
                         (detectionRange + player.localScale.x / 2);
        
        _detectionColor = isInRange ? Color.green : Color.red;
        // range içerisinde ise gizmo rengi yeşil değil ise kırmızı
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = _detectionColor;
        Gizmos.DrawWireSphere(transform.position, detectionRange);
    }
}
