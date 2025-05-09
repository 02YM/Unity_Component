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
        // 캡슐의 윗쪽 구의 중심 좌표를 계산해
        Vector3 point1 = transform.position + Vector3.up * (capsuleHeight / 2 - capsuleRadius);
        // 캡슐의 아랫쪽 구의 중심 좌표를 계산해
        Vector3 point2 = transform.position + Vector3.down * (capsuleHeight / 2 - capsuleRadius);
        // 캡슐을 어느 방향으로 쏠지 결정해
        Vector3 direction = transform.forward;

        if(Physics.CapsuleCast(point1, point2, capsuleRadius, direction, out RaycastHit hit, maxDistance))
        {
            Debug.DrawLine(transform.position, hit.point, Color.red);
            Debug.Log("충돌감지" + hit.collider.name);
        }

    }
}
