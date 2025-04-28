using UnityEngine;

public class ClosesPointOnBounds : MonoBehaviour
{
    Rigidbody rigid;
    [SerializeField] Transform target;
    
    void Start()
    {
        rigid = GetComponent<Rigidbody>();    
    }

    
    void Update()
    {
        Debug.Log($"타켓과 가장 가까운 충돌 영역내의 정점 포인트를 린턴하는 함수 : {rigid.ClosestPointOnBounds(target.position)}");
    }

    private void OnDrawGizmos()
    {
        Vector3 closePoints = rigid.ClosestPointOnBounds(target.position);

        Gizmos.color = Color.red;
        Gizmos.DrawLine(transform.position, closePoints);        
    }
}
