using UnityEngine;

public class AnimatorParameterSettings : MonoBehaviour
{
    Animator m_animator;

    void Start()
    {
        m_animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.B))
        {
            m_animator.SetBool("Attack", true);
        }

        if (Input.GetKeyDown(KeyCode.F))
        {
            m_animator.SetFloat("Move", 1f);
        }

        if (Input.GetKeyDown(KeyCode.D))
        {
            m_animator.SetInteger("Die", 1);
        }

        if (Input.GetKeyDown(KeyCode.T))
        {
            m_animator.SetTrigger("Skill");
        }

        if(Input.GetKeyDown(KeyCode.R))
        {
            m_animator.Rebind();
        }
    }
}
