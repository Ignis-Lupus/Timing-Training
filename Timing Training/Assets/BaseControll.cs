using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseControll : MonoBehaviour {

    public float time = 0.0f;



	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        Clock();
        PressedSpace();

	}

    void Clock()
    {

        if(time != 8.0f)
        {



        }

    }

    void PressedSpace()
    {

        if(Input.GetButton("Space"))
        {

            Debug.Log("Space Pressed");

        }

    }
}
