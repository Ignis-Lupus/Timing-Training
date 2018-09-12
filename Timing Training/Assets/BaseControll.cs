using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseControll : MonoBehaviour {

    public float time = 0.0f;
    public float shotTimer = 0.0f;

    public bool opponentIsDead = true;
    public bool triggerLock = false;

    public GameObject Plain;
    public GameObject Green;
    public GameObject Yellow;
    public GameObject Red;

    // Update is called once per frame
    void Update () {

        Clock();
        PressedSpace();

        if(time >= 8.5)
        {



        }

        if (time <= 9.0f)
        {

            time += Time.deltaTime;

        }

        if (time >= 8.5f)
        {



            Plain.SetActive(false);
            Green.SetActive(false);
            Yellow.SetActive(false);
            Red.SetActive(true);

        }

    }

    //tracking all the time based actions happens here
    void Clock()
    {

        if(opponentIsDead == true)
        {

            if (time >= 8.0f)
            {

                opponentIsDead = false;

            }

        }

        if(triggerLock == true && shotTimer <= 0.5f)
        {

            shotTimer += Time.deltaTime;

        }
        else
        {

            triggerLock = false;
            shotTimer = 0.0f;

        }
        

    }

    //trigger script
    void PressedSpace()
    {

        if(Input.GetButtonDown("Space") && triggerLock == false)
        {
            
            triggerLock = true;
            if(opponentIsDead == false && time <= 8.5f)
            {

                opponentIsDead = true;
                time = 0.0f;

                Plain.SetActive(false);
                Green.SetActive(true);
                Yellow.SetActive(false);
                Red.SetActive(false);

            }

        }

       

    }

    
}
