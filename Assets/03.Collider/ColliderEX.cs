
using UnityEngine;



public class ColliderEX : MonoBehaviour
{
    Collider2D collider;
    Rigidbody2D rigid;
    
    [SerializeField] Transform target1;
    [SerializeField] Collider2D target2;

    // 이동 관련 변수
    float moveMent;
    float jumpMent;
    [SerializeField] private float moveSpeed = 5f;
    [SerializeField] private float jumpForce = 5f;

    void Start()
    {
        collider = GetComponent<Collider2D>();
        rigid = GetComponent<Rigidbody2D>();

        Debug.Log($"{collider.isTrigger}");
        Debug.Log($"{collider.enabled}");
        Debug.Log($"{collider.bounds}");
        Debug.Log($"{collider.attachedRigidbody}");        
    }

    // Update is called once per frame
    void Update()
    {
        Move();

        Vector3 closesPoint = collider.ClosestPoint(target1.transform.position);
        Debug.DrawLine(transform.position, closesPoint, Color.red);

        RayReturn();
    }
    

    private void Move()
    {
        moveMent = Input.GetAxisRaw("Horizontal");
        jumpMent = Input.GetAxisRaw("Vertical");
        rigid.linearVelocity = new Vector2(moveMent * moveSpeed, jumpMent* jumpForce) ;
    }

    void RayReturn()
    {
        Ray ray = new Ray(transform.position, transform.right);
        RaycastHit hit;
        Physics.Raycast(ray, out hit);

        Debug.Log($"충돌한 물체는 {hit}입니다");
        Debug.DrawLine(transform.position, target1.transform.position);
    }
}
