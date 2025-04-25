using UnityEngine;

public class WorldToViewportPoint : MonoBehaviour
{
    public Transform enemy;
    public RectTransform ui;
    public Canvas canvas;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 viewportPos = Camera.main.WorldToViewportPoint(enemy.position);

        
        if(viewportPos.z < 0f || (viewportPos.x >= 0 && viewportPos.x <= 1 && viewportPos.y >=0 && viewportPos.y<=1))
        {
            ui.gameObject.SetActive(false);
            Debug.Log("ȭ�� �ȿ� ���� �ֽ��ϴ�.");
            return;
        }

        // ȭ�� �ȿ� ���� �����ϴ�.
        ui.gameObject.SetActive(true);
        Debug.Log("ȭ�� �ȿ� ���� �����ϴ�.");

        // ����Ʈ ������ ��� ���� ����ȭ
        Vector2 direction = new Vector2(viewportPos.x - 0.5f, viewportPos.y - 0.5f).normalized;

        // ȭ��ǥ�� ĵ���� ������� ������ ��ġ��Ű��
        Vector2 canvasCenter = canvas.GetComponent<RectTransform>().sizeDelta / 2f;
        ui.anchoredPosition = direction * 250f; // 250�� �Ÿ� (UI ����)

        // ȸ��
        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
        ui.rotation = Quaternion.Euler(0, 0, angle - 90f);

        /*
         * WorldToViewportPoint�� ������Ʈ�� ȭ�� ����� �ִ��� ������ ��ȯ����.
            (0.5, 0.5): ȭ�� ���߾�
            (0, 0): ���ϴ�
            (1, 1): ����

            ���� (x < 0 || x > 1 || y < 0 || y > 1)�̸� ȭ�� �ۿ� ����!
            �̰ɷ� ��� ȭ��ǥ, �̴ϸ� ��ġ ǥ��, HUD ������ ���� ���� �� �־�.
         */
    }
}
