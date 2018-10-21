using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UiManager : MonoBehaviour {

    private float time = 300;
    private string loseScene = "lose";
    private string winScene = "Win";
    private Animator anim;

    Enemy opponent;
    Player player;


    public Text timeText;
    public Text hpPlayer, hpOpponent;
    public Text stamina;

    public bool winPlayer { get; set; }
    public bool winOpponent { get; set; }


    // Use this for initialization
    void Start () {
        opponent = GameObject.Find("Ryu").GetComponent<Enemy>();
        player = GameObject.Find("Player").GetComponent<Player>();
        anim = GameObject.Find("Ref").GetComponent<Animator>();
    }


    // Update is called once per frame
    void Update() {

        string timemin = ((int)time / 60).ToString();

        string timeSeconds = ((int)time % 60).ToString();

        time -= Time.deltaTime;

        timeText.text = timemin + ":" + timeSeconds;
        hpPlayer.text = player.hp.ToString();
        hpOpponent.text = opponent.hp.ToString();
        stamina.text = "Stamina:" + player.stamina.ToString();

        if (time <= 0) {
            if (opponent.hp < player.hp){
                winPlayer = true;
                print("win mac");
            }
            else {
                winOpponent = true;
                print("win ryu");
            }
        }

        if (winPlayer) {
            anim.SetBool("KO", true);
            StartCoroutine(Win());
            winPlayer = false;
        }

        if (winOpponent) {
            anim.SetBool("KO", true);
            StartCoroutine(Lose());
            winOpponent = false;
        }
    }


    IEnumerator Win(){

        yield return new WaitForSeconds(3);
        SceneManager.LoadScene(winScene);
    }


    IEnumerator Lose()
    {

        yield return new WaitForSeconds(3);
        SceneManager.LoadScene(loseScene);
    }
}
