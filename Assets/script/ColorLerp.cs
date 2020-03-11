using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorLerp : MonoBehaviour {

    
    
    float starttime;
    
    public GameObject changeCircle;


    float t;

    int a,b,c;



    private void Start()
    {
        starttime = Time.time;
    }

    private void Update()
    {
        colorChange();

        a = 0;
        b = 0;
        c = 0;
    }



    private void colorChange() {


        if (a != 0)
        {
            

            changeCircle.GetComponent<Renderer>().material.color = Color.red;



        } else
        if (b != 0)
        {
            changeCircle.GetComponent<Renderer>().material.color = Color.green;

        } else
            if (c!=0)
        {
            changeCircle.GetComponent<Renderer>().material.color = Color.blue;

            


        }


    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "enemy")
        {


            a++;
            

           

        }else if (collision.tag == "food")
        {

            b++;

        }else if(collision.tag == "x2speed")
        {
            c++;

            move spd = new move();

            spd.speed.Equals(10);

        }



    }


    
    
    

}
