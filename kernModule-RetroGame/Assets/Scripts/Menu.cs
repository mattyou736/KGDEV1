using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour {

    private string newGameScene = "LevelScene";
    //private GameObject control;

    public GameObject Control;
    
    public void NewGame () {
        SceneManager.LoadScene(newGameScene);
    }


    public void Controls() {
        Control.SetActive(true);
    }


    public void Back() {
        Control.SetActive(false);
    }

    public void Exit() {
        Application.Quit();
    }

}
