using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DiscController : MonoBehaviour
{
    // Start is called before the first frame update

    public int discNumber;

    playerController player;

    EventController ui;

    QuestionController question;

    RecordsSpriteController recordView;

    int onetimeplace;
    void Start()
    {
        player = GameObject.Find("player").GetComponent<playerController>();
        ui = GameObject.Find("Canvas").GetComponent<EventController>();
        question = GameObject.Find("nowDonuts").GetComponent<QuestionController>();
        recordView = GameObject.Find("Records").GetComponent<RecordsSpriteController>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }



    void OnTriggerStay2D(Collider2D coll) {

        if(coll.gameObject.tag == "playerDisc" && player.holdDonut == true && ui.gameStart == true && player.havingNumber == question.donutnumber){
            //player.setHavingDonut(donutType);
            //if(player.havingNumber != 100){
            //}
            onetimeplace = player.havingNumber;
            player.havingDonut.SetActive(false);
            player.havingNumber = 100;
            ui.AddScore(100);
            question.questionChange();
            recordView.changeDiscView(onetimeplace);
        }

	}

    
}
