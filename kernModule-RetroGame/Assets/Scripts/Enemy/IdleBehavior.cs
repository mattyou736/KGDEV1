using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IdleBehavior : StateMachineBehaviour {

    int timer = 0;
    int timeRandom;
    int count;

	 // OnStateEnter is called when a transition starts and the state machine starts to evaluate this state
	override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex) {
        timeRandom = Random.Range(100, 200);
        count++;
    }

	// OnStateUpdate is called on each Update frame between OnStateEnter and OnStateExit callbacks
	override public void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex) {

        timer++;
        
        if(count >= 4){
            if (timer >= timeRandom){
                timer = 0;
                count = 0;
                animator.SetBool("Attack-Kick", true);
            }
        }
        else{
            if (timer >= timeRandom){
                timer = 0;
                animator.SetBool("Attack", true);
            }
        }

    }

	// OnStateExit is called when a transition ends and the state machine finishes evaluating this state
	override public void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex) {

	}

}
