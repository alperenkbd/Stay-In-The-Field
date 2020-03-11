using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class move : MonoBehaviour {


    public float speed=5f;

    public int a ;

    public GameObject x2;

    public GameObject spd;

    public GameObject GameOver;

    public GameObject circle;

    public area ar;

    public int Firstpoint;

    public Text metin;//oyun içi score 

    public Text panelScore;//Oyun sonu score

    public Rigidbody2D rb;

    public float DeltaX, DeltaY;


    private void Start()
    {
        Firstpoint = 0;

        metin.text = "score:" + Firstpoint;

        rb = GetComponent<Rigidbody2D>();

    }


    // Update is called once per frame
    void Update () {

        if (GameOver.active) {

            Time.timeScale = 0;

            panelScore.text = "YOUR SCORE:" + Firstpoint;


        }
        else
        {

            Time.timeScale = 1.0f;//replay yaptığında devam etmesi için

        }


        hareket();
        andhareket();

        if (a == 1)
        {

            alankucultme();



        }

        if (circle.transform.localScale != new Vector3(1, 1, 1))
        {
            if (Firstpoint % 20 == 0 && Firstpoint != 0)
            {

                alanbuyutme();

            }
        }

    }



    public void andhareket()
    {

        if (Input.touchCount > 0)
        {

            Touch touch = Input.GetTouch(0);

            Vector2 touchPos = Camera.main.ScreenToWorldPoint(touch.position);

            switch (touch.phase)
            {

                case TouchPhase.Began:
                    DeltaX = touchPos.x - transform.position.x;
                    DeltaY = touchPos.y - transform.position.y;

                    break;

                case TouchPhase.Moved:

                    rb.MovePosition(new Vector2(touchPos.x - DeltaX, touchPos.y - DeltaY));

                    break;

                case TouchPhase.Ended:

                    rb.velocity = Vector2.zero;

                    break;


            }

        }


    }







    public void hareket()
    {




        if (Input.GetKey(KeyCode.A))
        {

            transform.Translate(new Vector3(-speed * Time.deltaTime, 0, 0));
           


        }

        if (Input.GetKey(KeyCode.D))
        {

            transform.Translate(new Vector3(speed * Time.deltaTime, 0, 0));



        }

        if (Input.GetKey(KeyCode.W))
        {

            transform.Translate(new Vector3(0 , speed * Time.deltaTime, 0));



        }

        if (Input.GetKey(KeyCode.S))
        {

            transform.Translate(new Vector3(0, -speed * Time.deltaTime, 0));



        }

    }






    private void OnTriggerEnter2D(Collider2D collision)//Çarpışmaların olduğu yer
    {


        if (collision.tag == "food")//yeşile çarptığında
        {
            a = 0;


            Firstpoint += 5;
            metin.text = "score:" + Firstpoint;


        }
        

        if (collision.tag == "x2speed" )//maviye çarptığında
        {
            a =0;

            



            if (speed == 5)
            {
                speed = speed + 3;
                Instantiate(spd,new Vector2(-6,6) , Quaternion.identity);
                Instantiate(x2, new Vector2(-7,-1),Quaternion.identity);
                
            }


            Firstpoint += 2;
            metin.text = "score:" + Firstpoint;






        }
        if (collision.tag == "enemy")//kırmızıya çarptığında
        {

            a=1;

            speed = 5;

            Firstpoint -= 5;
            metin.text = "score:" + Firstpoint;


        }
        

    }


    public void alankucultme()
    {


        float x = -0.001f;

      

        circle.gameObject.transform.localScale += new Vector3(x, x, 0);




        if (circle.gameObject.transform.localScale.x <= 0.2 && circle.gameObject.transform.localScale.y <= 0.2)
        {

            GameOver.gameObject.SetActive(true);

        }

        

        }

        public void alanbuyutme()
    {

        float b = 0.001f;

           circle.gameObject.transform.localScale += new Vector3(b, b, 0);


    }

    }
