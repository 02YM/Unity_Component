using UnityEngine;
// Transform
// ������Ʈ�� ��ġ, ȸ��, ũ�⸦ ��Ÿ���� ������Ʈ�̴�.

public class TransformEX : MonoBehaviour
{

    [SerializeField] GameObject target;
    void Start()
    {
        #region ����/������Ƽ
        Debug.Log("position : " + transform.position);// ������Ʈ�� ���� ��ǥ
        Debug.Log("localPosition :" + transform.localPosition); // �θ� ������ ���� ��ǥ
        Debug.Log("rotation : " + transform.rotation); // ������Ʈ�� ���� ȸ�� ��
        Debug.Log("localRotation" + transform.localRotation); // �θ� ������ ȸ�� ��
        Debug.Log("eulerAngle" + transform.eulerAngles); // ȸ�� ������ ǥ��
        Debug.Log("localScale" + transform.localScale); //������Ʈ�� ũ��
        Debug.Log("parent" + transform.parent); // �θ� ������Ʈ ������ ��
        Debug.Log("forawrd, right, up" + transform.forward); // ������Ʈ�� ���� ����
        #endregion ����/������Ƽ
    }


    void Update()
    {
        if(Input.GetKeyDown(KeyCode.T)) // ������Ʈ�� �̵���Ŵ
        {
            Debug.Log("Translate");
            transform.Translate(2, 0, 0);
        }

        if (Input.GetKeyDown(KeyCode.R)) // ������Ʈ�� ȸ������
        {
            Debug.Log("Rotate");
            transform.Rotate(0, -180, 0);
        }

        if(Input.GetKeyDown(KeyCode.L)) // ������Ʈ�� Ÿ�� ������Ʈ�� �ٶ󺸰���
        {

            transform.LookAt(target.transform);
        }
        // TransformPoint(Vector3) ���� ��ǥ�� ���� ��ǥ�� ��ȯ
        // InverseTransformPoint(Vector3) ���� ��ǥ�� ���� ��ǥ�� ��ȯ
        // SetParent(Vector3, bool) bool = false �� �����ϸ� ���� ��ġ�� �θ� �������� ��������

        if (Input.GetKeyDown(KeyCode.C)) // �ڽ� ������Ʈ���� �θ𿡼� ��� �и���
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
