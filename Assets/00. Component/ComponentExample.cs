using UnityEngine;
// Component
// 기존에 존재하는 컴포넌트와 그 설정들을 다른 오브젝트에 복사-붙여넣기 하는 것이 가능하다.

public class ComponentExample : MonoBehaviour
{
    // 1. gameObject
    // 이 컴포넌트가 붙어 있는 GameObject를 가져오는 속성

    public GameObject gameObject;
    [SerializeField] string tagName;
    [SerializeField] GameObject prefab;
    private object hideFlags;
    CanvasRenderer canvas;

    void Start()
    {
        // 공개 메소드
        #region 공개 메소드
        gameObject.GetComponent<Transform>(); //현재 오브젝트에서 특정 컴포넌트를 가져올 떄 사용
        gameObject.GetComponentInChildren<Transform>(); //자식 오브젝트 중에서 컴포넌트를 찾아 반환
        gameObject.GetComponentInParent<Transform>(); //부모 오브젝트에서 컴포넌트를 찾을 때 사용.
        gameObject.TryGetComponent<Transform>(out Transform transform); //null 체크 없이 안전하게 가져오기
        gameObject.CompareTag(gameObject.tag); //오브젝트의 태그를 빠르게 비교할 때 사용
        gameObject.SendMessage("TestMessage", 5.0f); //오브젝트에 특정 메서드 호출
        //gameObject.BroadcastMessage(""); //자식 오브젝트 까지 포함해서 메서드 호출
        #endregion 공개 메소드
    }

    // Update is called once per frame
    void Update()
    {
        // 상속받은 변수/프로퍼티
        #region 상속받은 변수/프로퍼티
        if (Input.GetKeyDown(KeyCode.G))
        {
            Debug.Log($"현재 컴포넌트가 붙어있는 것은 {this.gameObject} 입니다.");
        }        

        if(Input.GetKeyDown(KeyCode.Space))
        {
            if(gameObject.CompareTag("Player"))
            {
                Debug.Log($"현재 태그는 {this.gameObject.tag} 입니다.");
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
            Debug.Log($"오브젝트의 이름은 {this.name} 입니다.");
        }
        #endregion 상속받은 변수/프로퍼티

        // 정적 메서드
        #region 정적 메서드
        if (Input.GetKeyDown(KeyCode.D))
        {
            Destroy(gameObject); // 게임 오브젝트, 컴포넌트 또는 에셋을 파괴함
        }

        if(Input.GetKeyDown(KeyCode.L))
        {
            DontDestroyOnLoad(gameObject); // 씬 전환 시에도 오브젝트가 파괴되지 않게함
        }

        if (Input.GetKeyDown(KeyCode.F))
        {
            canvas = FindAnyObjectByType<CanvasRenderer>(); // 아무거라도 하나라도 찾으면 반환
            if (canvas) Debug.Log("CanvasRenderer object found :" + canvas);
        }
        if (Input.GetKeyDown(KeyCode.I))
        {
            Instantiate(prefab); // 프리팹 또는 오브젝트를 본제함
        }
        #endregion 정적 메서드
    }

    void TestMessage(float t)
    {
        Debug.Log("SendMessage" + t);
    }

        
}
