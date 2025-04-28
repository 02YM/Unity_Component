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
        Debug.Log($"Ÿ�ϰ� ���� ����� �浹 �������� ���� ����Ʈ�� �����ϴ� �Լ� : {rigid.ClosestPointOnBounds(target.position)}");
    }

    private void OnDrawGizmos()
    {
        Vector3 closePoints = rigid.ClosestPointOnBounds(target.position);

        Gizmos.color = Color.red;
        Gizmos.DrawLine(transform.position, closePoints);        
    }
}
