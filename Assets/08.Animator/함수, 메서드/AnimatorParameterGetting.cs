using UnityEngine;

public class AnimatorParameterGetting : MonoBehaviour
{

    Animator m_Animator;

    void Start()
    {
        m_Animator = GetComponent<Animator>();
        m_Animator.SetBool("Attack", true);
        m_Animator.SetFloat("Move", 1);
        m_Animator.SetInteger("Die", 1);
        m_Animator.SetTrigger("Skill");
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log($"{m_Animator.GetBool("Attack")}");
            Debug.Log($"{m_Animator.GetFloat("Move")}");
            Debug.Log($"{m_Animator.GetInteger("Die")}");
            Debug.Log($"{m_Animator.GetCurrentAnimatorStateInfo(0).IsName("Skill")}");
            Debug.Log("Trgger는 애니메이션이 종료되면 false로 초기화 하기 떄문에 fals라고 뜸니다.!");
        }
    }
}
