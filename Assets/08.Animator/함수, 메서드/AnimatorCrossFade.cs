using UnityEngine;

public class AnimatorCrossFade : MonoBehaviour
{
    Animator m_Animator;
    [SerializeField] float durationTime = 3f;

    void Start()
    {
        m_Animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            m_Animator.CrossFade("Attack", durationTime, 0, 1f);
            
        }
        if(Input.GetKeyDown(KeyCode.R))
        {
            m_Animator.Rebind();
        }
    }
}
