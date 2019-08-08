using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EventController : MonoBehaviour
{
    // Start is called before the first frame update

    public int score = 0;

    Text gameOverText;

    Text scoreText;

    Text timeText;

    BGMController bgm;

    public GameObject buttons;

    public float startTime;
    public float limitTime;

    public bool gameStart = false;
    public bool gameEnd = false;

    void Start()
    {
        gameOverText = GameObject.Find("GameOver").GetComponent<Text>();
        scoreText = GameObject.Find("Score").GetComponent<Text>();
        timeText = GameObject.Find("Time").GetComponent<Text>();

        bgm = GameObject.Find("BGMController").GetComponent<BGMController>();
        buttons.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if(gameStart != true && gameEnd != true){
            startTime -= 1.0f * Time.deltaTime;
            gameOverText.text = ( (int) startTime ).ToString();
            if( startTime < 1.0f){
                gameStart = true;
            }
            
            timeText.text = "残り時間：" + ( (int)limitTime ).ToString() + "秒";

        }else if(gameStart == true && gameEnd != true){
            if( startTime >= 0.0f){
                gameOverText.text = "Let's Dancing!";
                startTime -= 1.0f * Time.deltaTime;
                bgm.StartBGM();
            }else{
                gameOverText.text = "";
            }

           limitTime -= 1.0f * Time.deltaTime;

            if(limitTime < 0.0f){
                gameEnd = true;
            }

            
            timeText.text = "残り時間：" + ( (int)limitTime ).ToString() + "秒";
        }

        if(gameEnd == true){
            limitTime += 1.0f * Time.deltaTime;//終わった後も踊らせるため
            timeText.text = "残り時間：" + "0秒";
            gameOverText.text = "FINISH!";

            if (buttons.activeSelf != true)
            {
                buttons.SetActive(true);
            }
        }

        
        scoreText.text = "Score:" + score.ToString();
    }


    public void AddScore(int point){
        if (gameStart && !gameEnd)
        {
            score += point;
        }
    }
}
