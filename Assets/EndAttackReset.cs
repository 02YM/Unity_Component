using UnityEngine;

public class EndAttackReset : StateMachineBehaviour
{
    public override void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        animator.SetBool("SpecialSkill 0", false);
    }
}
