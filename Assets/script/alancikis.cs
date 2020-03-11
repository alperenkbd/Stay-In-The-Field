using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class alancikis : MonoBehaviour {

    public GameObject GameOver;

    public void OnTriggerExit2D(Collider2D collision)
    {


        if (collision.gameObject.tag == "alan")
        {

            GameOver.gameObject.SetActive(true);


        }
     



    }




}
