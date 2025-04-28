using UnityEngine;

public class AddForce_ForceMode : MonoBehaviour
{

    private Rigidbody2D rigid;
    [SerializeField] float thrust = 20;

    void Start()
    {
        rigid = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        // �⺻ ���� Force�� �����˴ϴ�.
        // 1) AddForce.Force : ���� ������ �־������� ���������� �� ���� Ȱ���ؼ� ������ ������Ʈ ó���մϴ�.
        // Mass ���� ����ؼ� �������� ���� ���������� ó���ϴ� ����Դϴ�.

        // 2)ForceMode.Impulse : ���� �־����� �� �� ���� ����ؼ� ��� ������Ʈ ó���ϴ� ���
        // Mass ���� ����մϴ�.

        // 3)ForceMode.Acceleration : ���� ������ �־������� ���������� �� ���� Ȱ���ؼ� ������ ������Ʈ ó���մϴ�.
        // mass ���� ������� �ʽ��ϴ�.

        // 4)ForceMode.VelocityChange : ���� �־����� �� �� ���� ����ؼ� ��� ������Ʈ ó���ϴ� ���, �������� �ӵ��� �����ϴ� ���
        // mass ���� ������� �ʽ��ϴ�.

        if (Input.GetButtonDown("Jump"))
            rigid.AddForce(transform.up * thrust, ForceMode2D.Force);
    }
}
