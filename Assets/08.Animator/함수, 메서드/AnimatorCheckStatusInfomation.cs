using UnityEngine;

public class AnimatorCheckStatusInfomation : MonoBehaviour
{
    Animator m_Animator;

    void Start()
    {
        m_Animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.R))
        {
            m_Animator.Rebind();
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            m_Animator.SetTrigger("SpecialSkill");
            m_Animator.SetBool("SpecialSkill 0", true);

            if (m_Animator.GetCurrentAnimatorStateInfo(0).IsName("SpecialSkill"))
                Debug.Log("State : SpecialSkill가 실행중입니다.");

            Debug.Log($"{m_Animator.GetNextAnimatorStateInfo(0).IsName("SpecialSkill")} SpecialSkillRoot의 상태입니다.");

            Debug.Log($"{m_Animator.GetAnimatorTransitionInfo(0).IsName("SpecialSkill")}의 다음 상태 정보입니다.");                        
        }

        if (Input.GetKeyDown(KeyCode.I)) // SpecialSkillRoot진행 중일떄 사용해주세요!
        {
            Debug.Log($"{m_Animator.IsInTransition(0)} 상태 현재 진행 중입니다.");
        }
    }
}


