using UnityEngine;
using System.Collections;

public class playerController : MonoBehaviour {
	// 位置座標
	private Vector3 position;
	// スクリーン座標をワールド座標に変換した位置座標
	private Vector3 screenToWorldPointPosition;
    // Use this for initialization


    public GameObject[] handsDonuts;

    public GameObject havingDonut;
    public int havingNumber;

    public bool holdDonut = false;

    EventController ui;


    void Start () {
	   ui = GameObject.Find("Canvas").GetComponent<EventController>();
    }
	
	// Update is called once per frame
	void Update () {
		// Vector3でマウス位置座標を取得する
		position = Input.mousePosition;
		// Z軸修正
		position.z = 10f;
		// マウス位置座標をスクリーン座標からワールド座標に変換する
		screenToWorldPointPosition = Camera.main.ScreenToWorldPoint(position);
		// ワールド座標に変換されたマウス座標を代入
		gameObject.transform.position = screenToWorldPointPosition;


        if (ui.gameStart == true){


            if (Input.GetMouseButton(0))
            {
                holdDonut = true;
            }
            else
            {
                holdDonut = false;
            }


            if (holdDonut == false && havingDonut != null)
            {
                havingDonut.SetActive(false);
                havingNumber = 100;
                //havingDonut = null;
            }

        }

    }


    public void setHavingDonut(int n){
        if (n != havingNumber)
        {
			if(havingNumber != 100){
              handsDonuts[havingNumber].SetActive(false);
			}
            handsDonuts[n].SetActive(true);
            this.havingDonut = handsDonuts[n];
            havingNumber = n;
        }
    }


}