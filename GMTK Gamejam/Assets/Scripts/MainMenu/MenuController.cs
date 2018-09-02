using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class MenuController : MonoBehaviour {

    [SerializeField] private GameObject sureQuestion;
    [SerializeField] private GameObject quitButton;

    private bool controlsShowing = false;

    ControlsScreen cs;

    private void Start()
    {
        cs = GameObject.Find("ControlsPanel").GetComponent<ControlsScreen>();
    }

    public void StartGame()
    {
        //Start Game
        SceneManager.LoadScene(1);

    }

    public void Controls()
    {
        //Show Controls
        if (!controlsShowing)
        {
            //Animate Controls in
            cs.AnimateIn();
            controlsShowing = !controlsShowing;
        }
        else
        {
            //Animate Controls out
            cs.AnimateOut();
            controlsShowing = !controlsShowing;
        }
            
    }

    public void QuitGame(int quit)
    {
        //Close Game
        if(quit == 0)
        {
            //Show "U sure u want to quit"
            quitButton.SetActive(false);
            sureQuestion.SetActive(true);
        }
        else if(quit == 1)
        {
            //Yes, quit the game
            Application.Quit();
        }
        else if(quit == 2)
        {
            //No, Hide "U sure u want to quit"
            quitButton.SetActive(true);
            sureQuestion.SetActive(false);
        }

        
    }
}
