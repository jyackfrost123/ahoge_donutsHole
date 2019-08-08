using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpningControler : MonoBehaviour
{
    // Start is called before the first frame update

    float time = 0;

    public int type = 0;


    bool type1 = true;
    public float speed = 1.0f;

    public float hight = 0.0f;


    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        time += 1.0f * Time.deltaTime;

      if( type == 0){
        if( time % 3.4f <= 1.7f ){
            transform.Translate(Vector3.up * Time.deltaTime);
        }else{
            transform.Translate(Vector3.down * Time.deltaTime);
        }
      }

      if(type == 1){
        if( time % 1.8f <= 0.9f ){
            transform.Translate(Vector3.left * Time.deltaTime);
        }else{
            transform.Translate(Vector3.right * Time.deltaTime);            
        }
       }

       if(type == 2){
        if( this.transform.position.x <= -49.0f || this.transform.position.x >= -47.5f ){
                speed = -speed;
        }

            transform.Translate( new Vector3 (speed,0,0) * Time.deltaTime);


        }

        if(type == 3){
             if( this.transform.position.x <= -42.5f || this.transform.position.x >= -37.0f ){
                speed = -speed;
                hight = -hight;
            }


            transform.Translate( new Vector3 (speed,hight,0) * Time.deltaTime);
        }

    }
    
}
