using UnityEngine;

public class PhysicsCapsuleCast : MonoBehaviour
{
    public float capsuleHeight = 2;
    public float capsuleRadius = 0.5f;
    public float maxDistance = 5f;

    void Start()
    {
        
    }

    void Update()
    {
        // ĸ���� ���� ���� �߽� ��ǥ�� �����
        Vector3 point1 = transform.position + Vector3.up * (capsuleHeight / 2 - capsuleRadius);
        // ĸ���� �Ʒ��� ���� �߽� ��ǥ�� �����
        Vector3 point2 = transform.position + Vector3.down * (capsuleHeight / 2 - capsuleRadius);
        // ĸ���� ��� �������� ���� ������
        Vector3 direction = transform.forward;

        if(Physics.CapsuleCast(point1, point2, capsuleRadius, direction, out RaycastHit hit, maxDistance))
        {
            Debug.DrawLine(transform.position, hit.point, Color.red);
            Debug.Log("�浹����" + hit.collider.name);
        }

    }
}
