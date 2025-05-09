using UnityEngine;

// 충돌 여부를 판단합니다.
// Physics.IgnoreCollision : 충돌을 무시할지 여부를 설정하는 메서드
// Physics.GetIgnoreCollision : 충돌을 무시하고 있는지 확인하는 메서드

public class PhysicsGetIgnoreCollsion : MonoBehaviour
{
    public Collider playerCollider;   // 플레이어 Collider
    public Collider bulletCollider;   // 총알 Collider

    void Update()
    {
        // 'I' 키를 눌러서 충돌을 무시하도록 설정
        if (Input.GetKeyDown(KeyCode.I))
        {
            IgnoreCollision(true);
        }

        // 'C' 키를 눌러서 충돌을 허용하도록 설정
        if (Input.GetKeyDown(KeyCode.C))
        {
            IgnoreCollision(false);
        }

        // 현재 충돌 무시 상태를 출력
        CheckCollisionStatus();
    }

    // 충돌 무시/허용 상태를 설정하는 함수
    void IgnoreCollision(bool ignore)
    {
        Physics.IgnoreCollision(playerCollider, bulletCollider, ignore);

        if (ignore)
        {
            Debug.Log("플레이어와 총알의 충돌을 무시하도록 설정");
        }
        else
        {
            Debug.Log("플레이어와 총알의 충돌을 허용하도록 설정");
        }
    }

    // 현재 충돌 무시 상태를 확인하는 함수
    void CheckCollisionStatus()
    {
        bool isIgnoring = Physics.GetIgnoreCollision(playerCollider, bulletCollider);

        if (isIgnoring)
        {
            Debug.Log("현재: 충돌 무시 중");
        }
        else
        {
            Debug.Log("현재: 충돌 허용 중");
        }
    }
}