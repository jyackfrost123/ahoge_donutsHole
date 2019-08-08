using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameDancingController : MonoBehaviour
{

    //float time = 0;

    public int type = 0;

    EventController ui;

    public float hight;
    public float speed;
    public float MaxX;
    public float MinX;

    public float MaxY;
    public float MinY;
    public bool changesped = false;

    void Start()
    {
        ui = GameObject.Find("Canvas").GetComponent<EventController>();
    }

    // Update is called once per frame
    void Update()
    {
        //time += 1.0f * Time.deltaTime;

        if (type == 0 && ui.gameStart)
        {
            if (ui.limitTime % 3.6f <= 1.8f)
            {
                transform.Translate(Vector3.up * Time.deltaTime);
            }
            else
            {
                transform.Translate(Vector3.down * Time.deltaTime);
            }
        }

        if (type == 1 && ui.gameStart)
        {
            if (ui.limitTime % 1.8f <= 0.9f)
            {
                transform.Translate(Vector3.left * Time.deltaTime);
            }
            else
            {
                transform.Translate(Vector3.right * Time.deltaTime);
            }
        }

        if (type == 2 && ui.gameStart)
        {
            if (ui.limitTime >= 45.0f)
            {
                transform.Translate(new Vector3(15.0f, hight, 0) * Time.deltaTime);
            }
            else
            {
                if (this.transform.position.x <= MinX || this.transform.position.x >= MaxX)
                {
                    speed = -speed;
                    //hight = -hight;
                }
            }

            transform.Translate(new Vector3(speed, hight, 0) * Time.deltaTime);


        }

        if (type == 3 && ui.gameStart)
        {
            if (ui.limitTime >= 45.0f)
            {
                speed += 1.0f * Time.deltaTime;
            }
            else
            {
                if (this.transform.position.x <= MinX || this.transform.position.x >= MaxX)
                {
                    speed = -speed;
                    //hight = -hight;
                }
            }

            transform.Translate(new Vector3(speed, hight, 0) * Time.deltaTime);


        }


        if (type == 4 && ui.gameStart)
        {


                if ((transform.position.x <= MinX) || (transform.position.x >= MaxX))
                {
                    speed = -speed;
                }

                if ((transform.position.y <= MinY) || (transform.position.y >= MinY))
                {
                    hight = -hight;
                }

                 transform.Translate(new Vector3(speed, hight, 0) * Time.deltaTime);

        }

        if(type == 5 && ui.gameStart){
            hight = 0;
            if (ui.limitTime >= 15.0f)
            {
                speed -= 1.0f * Time.deltaTime;
            }
            else
            {
                if(!changesped){
                   speed = 2.0f;
                    changesped = true;
                }

                if (this.transform.position.x <= MinX || this.transform.position.x >= MaxX)
                {
                    speed = -speed;
                    //hight = -hight;
                }
            }

            transform.Translate(new Vector3(speed, hight, 0) * Time.deltaTime);
        }
    }

}

