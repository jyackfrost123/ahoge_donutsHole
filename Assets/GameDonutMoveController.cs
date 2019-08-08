using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameDonutMoveController : MonoBehaviour
{

    //float time = 0;

    EventController ui;

    float speed = 0.0f;
    float hight = 0.0f;

    bool speedBool = false;
    bool hightBool = false;

    void Start()
    {
        ui = GameObject.Find("Canvas").GetComponent<EventController>();
    }

    // Update is called once per frame
    void Update()
    {
        //time += 1.0f * Time.deltaTime;

      if(ui.limitTime <= 31.0f && ui.gameStart){
         if(!speedBool){
            speed = 1.0f;
            speedBool = true;
          }


        if(  (transform.position.x <= -17.0f) || (transform.position.x >= -10.0f) ){
                speed = -speed;
        }

      }

      if(ui.limitTime <= 31.0f && ui.gameStart){
         if(!hightBool){
            hight = 1.0f;
            hightBool = true;
          }

            if( (transform.position.y <= -5.0f) || (transform.position.y >= -2.0f) ){
                hight = -hight;
           }
       }

      if(ui.limitTime > 31.0 && ui.gameStart){
            speed = 0.0f;
            hight = 0.0f;
      }

        transform.Translate(new Vector3(speed, hight, 0) * Time.deltaTime);

    }
}
