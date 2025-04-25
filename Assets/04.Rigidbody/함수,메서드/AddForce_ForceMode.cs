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
        // 기본 모드는 Force로 설정됩니다.
        // 1) AddForce.Force : 힘과 방향이 주어졌을떄 내부족으로 이 값을 활용해서 서서히 업데이트 처리합니다.
        // Mass 값을 사용해서 연속적인 힘이 가해지도록 처리하는 모드입니다.

        // 2)ForceMode.Impulse : 힘이 주어졌을 때 그 힘을 사용해서 즉시 업데이트 처리하는 방식
        // Mass 값을 사용합니다.

        // 3)ForceMode.Acceleration : 힘과 방향이 주어졌을때 내부적으로 이 값을 활용해서 서서히 업데이트 처리합니다.
        // mass 값을 사용하지 않습니다.

        // 4)ForceMode.VelocityChange : 힘이 주어졌을 때 그 힘을 사용해서 즉시 업데이트 처리하는 방식, 순간적인 속도를 적용하는 모드
        // mass 값을 사용하지 않습니다.

        if (Input.GetButtonDown("Jump"))
            rigid.AddForce(transform.up * thrust, ForceMode2D.Force);
    }
}
