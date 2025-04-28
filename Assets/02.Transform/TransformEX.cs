using UnityEngine;
// Transform
// 오브젝트의 위치, 회전, 크기를 나타내는 컴포넌트이다.

public class TransformEX : MonoBehaviour
{

    [SerializeField] GameObject target;
    void Start()
    {
        #region 변수/프로퍼티
        Debug.Log("position : " + transform.position);// 오브젝트의 월드 좌표
        Debug.Log("localPosition :" + transform.localPosition); // 부모 기준의 로컬 좌표
        Debug.Log("rotation : " + transform.rotation); // 오브젝트의 월드 회전 값
        Debug.Log("localRotation" + transform.localRotation); // 부모 기준의 회전 값
        Debug.Log("eulerAngle" + transform.eulerAngles); // 회전 각도를 표현
        Debug.Log("localScale" + transform.localScale); //오브젝트의 크기
        Debug.Log("parent" + transform.parent); // 부모 오브젝트 설정할 떄
        Debug.Log("forawrd, right, up" + transform.forward); // 오브젝트의 방향 벡터
        #endregion 변수/프로퍼티
    }


    void Update()
    {
        if(Input.GetKeyDown(KeyCode.T)) // 오브젝트를 이동시킴
        {
            Debug.Log("Translate");
            transform.Translate(2, 0, 0);
        }

        if (Input.GetKeyDown(KeyCode.R)) // 오브젝트를 회전시힘
        {
            Debug.Log("Rotate");
            transform.Rotate(0, -180, 0);
        }

        if(Input.GetKeyDown(KeyCode.L)) // 오브젝트가 타겟 오브젝트를 바라보게함
        {

            transform.LookAt(target.transform);
        }
        // TransformPoint(Vector3) 로컬 좌표를 월드 좌표로 변환
        // InverseTransformPoint(Vector3) 월드 좌표를 로컬 좌표로 변환
        // SetParent(Vector3, bool) bool = false 로 설정하면 현재 위치가 부모 기준으로 재조정됨

        if (Input.GetKeyDown(KeyCode.C)) // 자식 오브젝트들을 부모에서 모두 분리함
        {
            transform.DetachChildren();
        }

    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.blue;
        Gizmos.DrawRay(transform.position, transform.forward * 5f);
        Gizmos.color = Color.red;
        Gizmos.DrawRay(transform.position, transform.up * 5f);
        Gizmos.color = Color.yellow;
        Gizmos.DrawRay(transform.position, transform.right * 5f);        
    }
}
