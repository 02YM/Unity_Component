using UnityEngine;

public class CollisionandDetectionEX : MonoBehaviour
{
    Collider2D collider;
    Rigidbody2D rigid;

    float moveMent;
    [SerializeField] float moveSpeed =5f;    

    void Start()
    {
        collider = GetComponent<Collider2D>();
        rigid = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        Move();
    }

    void Move()
    {
        moveMent = Input.GetAxisRaw("Horizontal");
        rigid.linearVelocity = new Vector2(moveMent * moveSpeed, 0);
    }

    #region 충돌 감지 메시지
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log($"{collision.transform.name} 에 충돌 하였습니다.");
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        Debug.Log($"{collision.transform.name} 에 벗어 났습니다.");
    }

    private void OnCollisionStay2D(Collision2D collision)
    {
        Debug.Log($"{collision.transform.name} 에 충돌 중입니다.");
    }
    #endregion 충돌 감지 메시지


    #region 트리거 감지 메시지

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log($"{collision.transform.name} 의 물체에 충돌 하였습니다.");
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        Debug.Log($"{collision.transform.name} 의 물체에 충돌에 벗어났습니다.");
    }
    private void OnTriggerStay2D(Collider2D collision)
    {
        Debug.Log($"{collision.transform.name} 의 물체에 충돌중입니다.");
    }
    #endregion 트리거 감지 메시지

    
}
