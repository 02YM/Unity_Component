using UnityEngine;

public class ScreenToViewportPoint : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {

        Vector3 mouseViewportPos = Camera.main.ScreenToViewportPoint(Input.mousePosition);

        if (mouseViewportPos.x < 0.5f)
            Debug.Log("���� ����");
        else
            Debug.Log("������ ����");

        if (mouseViewportPos.y < 0.5f)
            Debug.Log("�Ʒ��� ����");
        else
            Debug.Log("���� ����");

    }
}
