using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndGameScript : MonoBehaviour {

    
    public void retry()
    {

        SceneManager.LoadScene(1);


    }


    public void loadmain()
    {

        SceneManager.LoadScene(0);


    }


}
