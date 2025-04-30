using UnityEngine;
using static UnityEditor.Experimental.GraphView.GraphView;

public class AnimatorPlay : MonoBehaviour
{
    
    Animator m_Animator;

    void Start()
    {
        m_Animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            m_Animator.Play("Attack", 0);
        }
    }
}
