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
                Debug.Log("State : SpecialSkill�� �������Դϴ�.");

            Debug.Log($"{m_Animator.GetNextAnimatorStateInfo(0).IsName("SpecialSkill")} SpecialSkillRoot�� �����Դϴ�.");

            Debug.Log($"{m_Animator.GetAnimatorTransitionInfo(0).IsName("SpecialSkill")}�� ���� ���� �����Դϴ�.");                        
        }

        if (Input.GetKeyDown(KeyCode.I)) // SpecialSkillRoot���� ���ϋ� ������ּ���!
        {
            Debug.Log($"{m_Animator.IsInTransition(0)} ���� ���� ���� ���Դϴ�.");
        }
    }
}


