using UnityEngine;

public class PhysicsBoxCast : MonoBehaviour
{

    public float castDistance = 5;
    public Vector3 boxHalfExtents = new Vector3(0.5f, 0.5f, 0.5f);
    public LayerMask targetLayer;
    public Vector3 endPoint;

    void Start()
    {
        
    }

    
    void Update()
    {
        RaycastHit hit;
        Ray ray = new Ray(transform.position, transform.forward);
        endPoint = ray.origin + ray.direction * castDistance;

        if(Physics.BoxCast(transform.position,boxHalfExtents, transform.forward, out hit, transform.rotation, castDistance, targetLayer))
        {
            Debug.Log("출돌 감지" + hit.collider.name);
        }

        Debug.DrawRay(transform.position, transform.forward * castDistance, Color.red);        
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.yellow;
        Gizmos.DrawWireCube(endPoint, boxHalfExtents);
    }
}
