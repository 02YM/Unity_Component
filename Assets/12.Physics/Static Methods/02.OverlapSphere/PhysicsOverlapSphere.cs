using UnityEngine;

public class PhysicsOverlapSphere : MonoBehaviour
{
    public float radius = 5f;
    public Vector3 SpherePosition = new Vector3(0, 1, 0);

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Collider[] hits = Physics.OverlapSphere(SpherePosition, radius);
           
        foreach(Collider hit in hits)
        {
            Debug.Log(hit.name);
        }                
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(SpherePosition, radius);
    }
}
