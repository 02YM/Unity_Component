using UnityEngine;

public class PhysicsIgnoreCollsion : MonoBehaviour
{
    [Header("True면 무시, false면 허용")]
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
            Debug.Log("충돌되었습니다." + collision.gameObject.name);
    }

    
}
