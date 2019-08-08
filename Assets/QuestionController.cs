using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuestionController : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject nowQuestion;

    SpriteRenderer nowsprite;
    public Sprite[] questionDonuts;

    EventController ui;

    public int donutnumber = 0;

    //int donutPlace = 0;
    public int pre_donutnumber = 1;

    float questionTime = 0.0f;
    public float questionMax;


    void Start()
    {
        nowsprite = nowQuestion.GetComponent<SpriteRenderer>();
        ui = GameObject.Find("Canvas").GetComponent<EventController>();
    }

    // Update is called once per frame
    void Update()
    {
        if (ui.gameStart == true)
        {
            questionTime -= 1.0f * Time.deltaTime;
        }

        if(questionTime <= 0.0f){
            questionChange();
        }

        //Debug.Log(questionDonuts.Length);


    }

    public void questionChange(){
       questionTime = questionMax;//出題時間変更
            
       //donutPlace = donutnumber;
        pre_donutnumber = donutnumber;

       while(true){
         donutnumber = Random.Range( 0 , questionDonuts.Length);
         if(donutnumber != pre_donutnumber) break;
        }


       nowsprite.sprite = questionDonuts[donutnumber];
    }
}
