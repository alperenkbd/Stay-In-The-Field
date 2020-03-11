using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionBehavior : MonoBehaviour {


    public GameObject effect;

   



    private void OnTriggerEnter2D(Collider2D collision)
    {

        

        if (collision.gameObject.tag == "karakter")
        {

            

            Instantiate(effect, transform.position, Quaternion.identity);

            

            Destroy(this.gameObject);

            
           

        }


        

    }

}
