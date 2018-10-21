using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KoBehavior : StateMachineBehaviour {

    public GameObject downAudio;

	 // OnStateEnter is called when a transition starts and the state machine starts to evaluate this state
	override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex) {
        var audiodown = (GameObject)Instantiate(downAudio, new Vector3(-0.76f, 2.14f, 0), Quaternion.identity);

    }

	// OnStateUpdate is called on each Update frame between OnStateEnter and OnStateExit callbacks
	override public void OnStateUpdate(Animator animator, AnimatorStateInfo stateInfo, int layerIndex) {
	
	}

	// OnStateExit is called when a transition ends and the state machine finishes evaluating this state
	override public void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex) {
	
	}

}
