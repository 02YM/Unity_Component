using UnityEngine;
// Component
// ������ �����ϴ� ������Ʈ�� �� �������� �ٸ� ������Ʈ�� ����-�ٿ��ֱ� �ϴ� ���� �����ϴ�.

public class ComponentExample : MonoBehaviour
{
    // 1. gameObject
    // �� ������Ʈ�� �پ� �ִ� GameObject�� �������� �Ӽ�

    public GameObject gameObject;
    [SerializeField] string tagName;
    [SerializeField] GameObject prefab;
    private object hideFlags;
    CanvasRenderer canvas;

    void Start()
    {
        // ���� �޼ҵ�
        #region ���� �޼ҵ�
        gameObject.GetComponent<Transform>(); //���� ������Ʈ���� Ư�� ������Ʈ�� ������ �� ���
        gameObject.GetComponentInChildren<Transform>(); //�ڽ� ������Ʈ �߿��� ������Ʈ�� ã�� ��ȯ
        gameObject.GetComponentInParent<Transform>(); //�θ� ������Ʈ���� ������Ʈ�� ã�� �� ���.
        gameObject.TryGetComponent<Transform>(out Transform transform); //null üũ ���� �����ϰ� ��������
        gameObject.CompareTag(gameObject.tag); //������Ʈ�� �±׸� ������ ���� �� ���
        gameObject.SendMessage("TestMessage", 5.0f); //������Ʈ�� Ư�� �޼��� ȣ��
        //gameObject.BroadcastMessage(""); //�ڽ� ������Ʈ ���� �����ؼ� �޼��� ȣ��
        #endregion ���� �޼ҵ�
    }

    // Update is called once per frame
    void Update()
    {
        // ��ӹ��� ����/������Ƽ
        #region ��ӹ��� ����/������Ƽ
        if (Input.GetKeyDown(KeyCode.G))
        {
            Debug.Log($"���� ������Ʈ�� �پ��ִ� ���� {this.gameObject} �Դϴ�.");
        }        

        if(Input.GetKeyDown(KeyCode.Space))
        {
            if(gameObject.CompareTag("Player"))
            {
                Debug.Log($"���� �±״� {this.gameObject.tag} �Դϴ�.");
            }
        }

        if (Input.GetKeyDown(KeyCode.H))
        {
            hideFlags = HideFlags.HideInInspector;
            Debug.Log($"{this.hideFlags}");
        }

        if(Input.GetKeyDown(KeyCode.N))
        {
            this.name = gameObject.name;
            Debug.Log($"������Ʈ�� �̸��� {this.name} �Դϴ�.");
        }
        #endregion ��ӹ��� ����/������Ƽ

        // ���� �޼���
        #region ���� �޼���
        if (Input.GetKeyDown(KeyCode.D))
        {
            Destroy(gameObject); // ���� ������Ʈ, ������Ʈ �Ǵ� ������ �ı���
        }

        if(Input.GetKeyDown(KeyCode.L))
        {
            DontDestroyOnLoad(gameObject); // �� ��ȯ �ÿ��� ������Ʈ�� �ı����� �ʰ���
        }

        if (Input.GetKeyDown(KeyCode.F))
        {
            canvas = FindAnyObjectByType<CanvasRenderer>(); // �ƹ��Ŷ� �ϳ��� ã���� ��ȯ
            if (canvas) Debug.Log("CanvasRenderer object found :" + canvas);
        }
        if (Input.GetKeyDown(KeyCode.I))
        {
            Instantiate(prefab); // ������ �Ǵ� ������Ʈ�� ������
        }
        #endregion ���� �޼���
    }

    void TestMessage(float t)
    {
        Debug.Log("SendMessage" + t);
    }

        
}
