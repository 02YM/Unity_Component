using UnityEngine;

// �浹 ���θ� �Ǵ��մϴ�.
// Physics.IgnoreCollision : �浹�� �������� ���θ� �����ϴ� �޼���
// Physics.GetIgnoreCollision : �浹�� �����ϰ� �ִ��� Ȯ���ϴ� �޼���

public class PhysicsGetIgnoreCollsion : MonoBehaviour
{
    public Collider playerCollider;   // �÷��̾� Collider
    public Collider bulletCollider;   // �Ѿ� Collider

    void Update()
    {
        // 'I' Ű�� ������ �浹�� �����ϵ��� ����
        if (Input.GetKeyDown(KeyCode.I))
        {
            IgnoreCollision(true);
        }

        // 'C' Ű�� ������ �浹�� ����ϵ��� ����
        if (Input.GetKeyDown(KeyCode.C))
        {
            IgnoreCollision(false);
        }

        // ���� �浹 ���� ���¸� ���
        CheckCollisionStatus();
    }

    // �浹 ����/��� ���¸� �����ϴ� �Լ�
    void IgnoreCollision(bool ignore)
    {
        Physics.IgnoreCollision(playerCollider, bulletCollider, ignore);

        if (ignore)
        {
            Debug.Log("�÷��̾�� �Ѿ��� �浹�� �����ϵ��� ����");
        }
        else
        {
            Debug.Log("�÷��̾�� �Ѿ��� �浹�� ����ϵ��� ����");
        }
    }

    // ���� �浹 ���� ���¸� Ȯ���ϴ� �Լ�
    void CheckCollisionStatus()
    {
        bool isIgnoring = Physics.GetIgnoreCollision(playerCollider, bulletCollider);

        if (isIgnoring)
        {
            Debug.Log("����: �浹 ���� ��");
        }
        else
        {
            Debug.Log("����: �浹 ��� ��");
        }
    }
}