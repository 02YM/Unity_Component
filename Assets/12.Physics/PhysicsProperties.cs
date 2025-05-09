using UnityEditor.Experimental.GraphView;
using UnityEngine;
using UnityEngine.InputSystem;

public class PhysicsProperties : MonoBehaviour
{
    [Header("Gravity")]
    [SerializeField] private bool Gravity = false;
    [Header("ContactOffset Yellow")]
    [SerializeField] private bool ContactOffset = false;
    [SerializeField] private Vector3 contactOffset = Vector3.zero;

    [Header("Solver")]
    [SerializeField] private bool Solver = false;

    [Header("Hit")]
    [SerializeField] private bool HitTriggers = false;
    [SerializeField] private bool HitBackfase = false;

    [Header("SyncTransforms")]
    [SerializeField] private bool SyncTransform = false;

    [Header("SleepThreshold")]
    [SerializeField] private bool SleepThreshold = false;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            Ray mouse = Camera.main.ScreenPointToRay(Input.mousePosition);
            if(Physics.Raycast(mouse, out RaycastHit hit) && Physics.queriesHitTriggers || Physics.queriesHitBackfaces)
            {
                Debug.Log("클릭한 오브젝트" + hit.collider.name);
            }
        }
        


        if (Gravity)
            Physics.gravity = new Vector3(0, -20f, 0);
        else if (!Gravity)
            Physics.gravity = new Vector3(0, -1f, 0);

        if (ContactOffset)
            contactOffset = new Vector3(Physics.defaultContactOffset = 10, Physics.defaultContactOffset = 10, Physics.defaultContactOffset = 10);            
        else if (!ContactOffset)
            contactOffset = new Vector3(Physics.defaultContactOffset = 0.01f, Physics.defaultContactOffset = 0.01f, Physics.defaultContactOffset = 0.01f);

        if (Solver)
        {
            Physics.defaultSolverIterations = 10;
            Physics.defaultSolverVelocityIterations = 5;            
        }            
        else if (!Solver)
        {
            Physics.defaultSolverIterations = 1;
            Physics.defaultSolverVelocityIterations = 1;
        }

        if (HitTriggers)
        {
            Physics.queriesHitTriggers = true;
            if (HitBackfase)
                Physics.queriesHitBackfaces = true;
        }
            
        else if(!HitTriggers)
        {
            Physics.queriesHitTriggers = false;
            if (!HitBackfase)
                Physics.queriesHitBackfaces = false;
        }

        if(SyncTransform)
        {
            Physics.autoSyncTransforms = true;

            if(Input.GetKeyDown(KeyCode.Space))
            {
                transform.position += new Vector3(0, 1, 0);

                Physics.SyncTransforms();

                Debug.Log("Transform 위치 변경 후 물리 동기화 완료");
            }
        }
        else if(!SyncTransform)
        {
            Physics.autoSyncTransforms=false;
        }
            
        if(SleepThreshold)
        {
            Physics.sleepThreshold = 0.0001f;
        }
        else if(!SleepThreshold)
        {
            Physics.sleepThreshold = 1;
        }

    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.yellow;
        Gizmos.DrawWireCube(transform.position, contactOffset);
    }
}
