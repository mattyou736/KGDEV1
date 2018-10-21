using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Kick : MonoBehaviour {
    private Player player;

    // Use this for initialization
    void Start () {
        player = GameObject.Find("Player").GetComponent<Player>();
    }

    public void OnTriggerEnter2D(Collider2D col) {
        
        if (col.gameObject.tag == "Player") {
            player.LoseHP();
        }
    }
}
