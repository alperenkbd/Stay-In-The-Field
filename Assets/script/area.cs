using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class area : MonoBehaviour {


    public GameObject GameOver;


    public void alankucultme()
    {
         
       
        float x = -0.001f;

            gameObject.transform.localScale += new Vector3(x, x, 0);

        


        if (gameObject.transform.localScale.x <= 0.1 && gameObject.transform.localScale.y <= 0.1)
        {

            GameOver.gameObject.SetActive(true);

        }
    }

}
