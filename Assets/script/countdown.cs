using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class countdown : MonoBehaviour {

    float currentTime=3.0f;
    float countDown=0.0f;

  

     [SerializeField]  Text  countdowntext;

    private void Start()
    {

        countDown = currentTime;



    }

    private void Update()
    {

        currentTime -= 1 * Time.deltaTime;

        countdowntext.text = currentTime.ToString("0");

        if (currentTime <= 0)
        {
            currentTime = 0;

            countdowntext.enabled = false;
        }
    }







}
