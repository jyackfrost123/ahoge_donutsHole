using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameRecordMoveController : MonoBehaviour
{
    // Start is called before the first frame update


    EventController ui;

    float speed = 0.0f;

    bool speedBool = false;

    void Start()
    {
       ui = GameObject.Find("Canvas").GetComponent<EventController>();
    }

    // Update is called once per frame
    void Update()
    {


        if (ui.limitTime <= 15.0f && ui.gameStart)
        {
            if (!speedBool)
            {
                speed = 4.5f;
                speedBool = true;
            }


            if ((transform.position.x <= -15.0f) || (transform.position.x >= -4.0f))
            {
                speed = -speed;
            }


        }

        if(ui.limitTime > 15.0 && ui.gameStart){
            speed = 0.0f;
         }

        transform.Translate(new Vector3(speed, 0, 0) * Time.deltaTime);
        
    }

    
}
