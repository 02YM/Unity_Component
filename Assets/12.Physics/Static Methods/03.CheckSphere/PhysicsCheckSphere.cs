using UnityEngine;

public class PhysicsCheckSphere : MonoBehaviour
{
    public float radius = 2f;
    public Vector3 SpherePosition = new Vector3(0, 1, 0);

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Physics.CheckSphere(SpherePosition, radius))
        {
            Debug.Log("물체가 감지되었습니다.");
        }
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(SpherePosition, radius);
    }
}
