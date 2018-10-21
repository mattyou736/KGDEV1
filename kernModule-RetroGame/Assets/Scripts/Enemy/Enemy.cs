using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    
    private bool left, right;
    private Animator anim;
    private UiManager manager;


    public int hp = 100;
    public bool gotHit, attack, ko;


    // Use this for initialization
    void Start () {
        anim = GetComponent<Animator>();
        manager = GameObject.Find("Canvas").GetComponent<UiManager>();

    }

    public void LoseHP() {
        hp -= 10;
        if (hp <= 0){
            Die();
        }
    }


    void Die() {
        manager.winPlayer = true;
        ko = true;
        anim.SetBool("Ko", ko);
    }

    

    public void OnTriggerEnter2D(Collider2D col) {
        if (col.gameObject.tag == "Haduoken"){
            gotHit = true;
            anim.SetBool("GotHit", gotHit);
            LoseHP();
        }
    }
}
