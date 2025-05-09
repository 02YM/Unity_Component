using UnityEngine;

public class PhysicsRayCast : MonoBehaviour
{
    public float distance = 5f;
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Ray ray = new Ray(transform.position, transform.forward);
        RaycastHit hit; // Ray�� ���� ������Ʈ�� ���� ����

        if(Physics.Raycast(ray, out hit, distance))
        {
            Debug.Log(hit.collider.name);
        }

        Debug.DrawRay(transform.position, transform.forward * distance, Color.red);
    }

}
