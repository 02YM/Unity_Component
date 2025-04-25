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

    #region �浹 ���� �޽���
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log($"{collision.transform.name} �� �浹 �Ͽ����ϴ�.");
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        Debug.Log($"{collision.transform.name} �� ���� �����ϴ�.");
    }

    private void OnCollisionStay2D(Collision2D collision)
    {
        Debug.Log($"{collision.transform.name} �� �浹 ���Դϴ�.");
    }
    #endregion �浹 ���� �޽���


    #region Ʈ���� ���� �޽���

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log($"{collision.transform.name} �� ��ü�� �浹 �Ͽ����ϴ�.");
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        Debug.Log($"{collision.transform.name} �� ��ü�� �浹�� ������ϴ�.");
    }
    private void OnTriggerStay2D(Collider2D collision)
    {
        Debug.Log($"{collision.transform.name} �� ��ü�� �浹���Դϴ�.");
    }
    #endregion Ʈ���� ���� �޽���

    
}
