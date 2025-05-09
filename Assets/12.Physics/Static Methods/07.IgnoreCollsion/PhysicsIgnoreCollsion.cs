using UnityEngine;

public class PhysicsIgnoreCollsion : MonoBehaviour
{
    [Header("True�� ����, false�� ���")]
    public bool IngoreCollision = false;

    public Collider playerCollider;
    public Rigidbody player;
    public Collider EnemyCollider;
    public Rigidbody enemy;


    void Start()
    {
            
    }

    // Update is called once per frame
    void Update()
    {
        if (IngoreCollision)
        {
            Physics.IgnoreCollision(playerCollider, EnemyCollider, true);            
        }
        else if(!IngoreCollision)
        {
            Physics.IgnoreCollision(playerCollider, EnemyCollider, false);            
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag("Enemy"))
            Debug.Log("�浹�Ǿ����ϴ�." + collision.gameObject.name);
    }

    
}
