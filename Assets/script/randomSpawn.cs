using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class randomSpawn : MonoBehaviour {


    public GameObject enemy, bounce, snakeTail;

    public float spawnTime= 2.0f;

    public float nextSpawn = 0f;

    public int whatToSpawn;

    public Text countdowntext;

    private Vector2 screenBound;

    public GameObject spawner;

    public GameObject GameOver;

    float tm = 40.0f;

    void Start()
    {

           StartCoroutine(RandomSpawn());
        

        screenBound = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z));

        spawner.transform.position = new Vector3(spawner.transform.position.x, Random.Range(-screenBound.y, screenBound.y), spawner.transform.position.z);

        

    }

    

    void Update()
    {


        keepTime();
        

        if (!countdowntext.enabled) {

            if (Time.time > nextSpawn)
            {
                whatToSpawn = Random.Range(1, 4);


                switch (whatToSpawn)
                {

                    case 1:


                        Instantiate(enemy, transform.position, Quaternion.identity);


                        break;

                    case 2:


                        Instantiate(bounce, transform.position, Quaternion.identity);


                        break;

                    case 3:

                        Instantiate(snakeTail, transform.position, Quaternion.identity);


                        break;


                }

                nextSpawn = Time.time + spawnTime;
            }

        }

        
           



    }

       
     public void keepTime()
    {



        tm -= Time.deltaTime;


        Debug.Log(tm);
        if (tm<0)
        {

            
            this.spawnTime = 1.0f;

        }

       
        

    }
    



    IEnumerator RandomSpawn()
    {

        

        while (true)
        {

            yield return new WaitForSeconds(spawnTime);
            
            spawner.transform.position = new Vector3(spawner.transform.position.x, Random.Range(-screenBound.y, screenBound.y), spawner.transform.position.z);

            
        }



    }
}
