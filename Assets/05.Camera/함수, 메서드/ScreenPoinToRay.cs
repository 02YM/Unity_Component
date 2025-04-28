using UnityEngine;
using UnityEngine.InputSystem;

public class ScreenPoinToRay : MonoBehaviour
{
    public Camera cam;
    public GameObject effectPrefab; // ��ȯ�� ����Ʈ ������
    public LayerMask layerMask;     // �� ���̰� ���� ���̾� ����
    public bool isClick = false;

    private void Start()
    {
        
    }

    private void Update()
    {
        if (Mouse.current.leftButton.wasPressedThisFrame && isClick == false) // ���콺 ���� Ŭ��
        {
            isClick = true;
            Ray ray = cam.ScreenPointToRay(Mouse.current.position.ReadValue());

            if (Physics.Raycast(ray, out RaycastHit hitInfo, 100f, layerMask))
            {
                // �浹 ������ ����Ʈ ��ȯ
                Instantiate(effectPrefab, hitInfo.point, Quaternion.identity);

                Debug.Log($"Effect spawned at {hitInfo.point} on {hitInfo.collider.name}");
            }
            isClick = false;
        }
    }
}
