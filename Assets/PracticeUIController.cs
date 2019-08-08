using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PracticeUIController : MonoBehaviour
{
    // Start is called before the first frame update

    public int pageNum = 0;

    public GameObject backbutton;

    public GameObject frontbutton;

    Text ui;
    void Start()
    {
       ui = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        if(pageNum != 0){
            backbutton.SetActive(true);
        }else{
            backbutton.SetActive(false);
        }

       /*  if(pageNum != Max){
             frontbutton.SetActive(true);
        }else{
             frontbutton.SetActive(false);
        }*/

        if(pageNum == 0){
            ui.text = "やあ、君が新しいバイト、"+"\n"+"ドーナツ君だね。"+"\n"+"俺の名前はドーナツ。"+"\n"+"ドーナツ先輩とでも呼んでくれ。";
        }

        if(pageNum == 1){
            ui.text = "ここはドーナツホール。"+"\n"+"見ての通り、ドーナツの踊り場なんだ。"+"\n"+"ドーナツとドーナツが出合い、"+"\n"+"コミュニティの円を作る…。"+"\n"+"そんな場所なのさ。";
        }


        if(pageNum == 2){
            ui.text =  "君には、" + "\n" + "ダンスフロアの曲を調整してもらう。" + "\n" + "難しいと思うかもしれないが、" + "\n" + "作業自体はオールドファッション。";
        }

       　if(pageNum == 3){
            ui.text =  "俺が曲を指定するから、" + "\n" + "その曲にあったドーナツ盤を、" + "\n" + "プレイヤーにセットしてくれ。" ;
        }
　　　　　　　
       // ""

    }

    public void goPage(){
        pageNum++;
    }

    public void backPage(){
        pageNum--;
    }

}
