using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScreenBoundControl : MonoBehaviour {


    

    public GameObject cntrl;

    private Vector2 screenBound;

    void Start () {

        

        screenBound = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z));

    }
	
	
	void Update () {

        Debug.Log(cntrl.transform.position.y);

        if (-10 > cntrl.transform.position.y)
        {
            
            Destroy(cntrl);

        }

    }
}
