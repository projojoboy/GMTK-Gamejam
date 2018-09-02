using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class MenuController : MonoBehaviour {

    [SerializeField] private GameObject sureQuestion;
    [SerializeField] private GameObject quitButton;

	public void StartGame()
    {
        //Start Game
    }

    public void Controls()
    {
        //Show Controls
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
            Debug.Log("Closing game");
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
