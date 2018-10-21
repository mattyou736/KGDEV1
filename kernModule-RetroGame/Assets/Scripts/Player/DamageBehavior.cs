﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageBehavior : StateMachineBehaviour {

    Player player;

    // OnStateEnter is called when a transition starts and the state machine starts to evaluate this state
    override public void OnStateEnter(Animator animator, AnimatorStateInfo stateInfo, int layerIndex){
        player = GameObject.Find("Player").GetComponent<Player>();
    }


    // OnStateExit is called when a transition ends and the state machine finishes evaluating this state
    override public void OnStateExit(Animator animator, AnimatorStateInfo stateInfo, int layerIndex){
        player.dodging = false;
    }
}
