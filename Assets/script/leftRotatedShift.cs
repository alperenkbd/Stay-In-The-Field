using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class leftRotatedShift : MonoBehaviour
{

    public float speed = 10.0f;

    private Rigidbody2D rb1;

    public GameObject obje;

    private Vector2 screenBound;




    void Start()
    {

        rb1 = obje.GetComponent<Rigidbody2D>();

        rb1.velocity = new Vector2(speed, 0);

        screenBound = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z));


    }

    private void Update()
    {

        if (screenBound.x < rb1.transform.position.x)
        {

            Destroy(this.gameObject);




        }

        



    }

    
}
