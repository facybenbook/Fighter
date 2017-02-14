﻿using UnityEngine;
using System.Collections;

public class LeftKick : StateMachineBehaviour {

    // OnStateEnter is called when a transition starts and the state machine starts to evaluate this state
    override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        Fighter fighter = animator.GetComponent<Fighter>();
        if (fighter != null)
        {
            // update player state
            fighter.SetLeftLegActive(true);
            FindObjectOfType<MusicManager>().PlayAttack();
        }
    }

    // OnStateExit is called when a transition ends and the state machine finishes evaluating this state
    override public void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex)
    {
        Fighter fighter = animator.GetComponent<Fighter>();
        if (fighter != null)
        {
            // update player state
            fighter.SetLeftLegActive(false);
        }
    }
}