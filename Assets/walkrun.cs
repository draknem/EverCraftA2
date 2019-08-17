using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class walkrun : StateMachineBehaviour
{
    public float isRunning = 1f;
    // OnStateUpdate is called on each Update frame between OnStateEnter and OnStateExit callbacks
    //override public void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    //{
    //    
    //}
    override public void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        isRunning = animator.GetFloat("Running");
        animator.speed = isRunning;
    }
}
