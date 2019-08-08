using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class itemController : MonoBehaviour
{
    // Start is called before the first frame update

    float fallSpeed;
	float rotSpeed;

    playerController player;
    EventController ui;

    public int donutType;

    void Start(){
        //this.fallSpeed = 0.01f + 0.1f * Random.value;
        player = GameObject.Find("player").GetComponent<playerController>();
        ui = GameObject.Find("Canvas").GetComponent<EventController>();
        this.rotSpeed = 5f + 3f * Random.value;
    }

    // Update is called once per frame
    void Update(){
        //transform.Translate( 0, -fallSpeed, 0, Space.World);
		//transform.Rotate(0, 0, rotSpeed );
        
    }

    void OnTriggerStay2D(Collider2D coll) {
		//Destroy (coll.gameObject);
		//Destroy (gameObject);

        if(coll.gameObject.tag == "Player" && player.holdDonut == true && ui.gameStart == true ){
            player.setHavingDonut(donutType);
        }
	}





}
