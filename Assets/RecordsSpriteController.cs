using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RecordsSpriteController : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject[] discView;
    public GameObject nowDiscView;

    //public int nowdiscView = 100;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void changeDiscView(int n){
        nowDiscView.SetActive(false);
        discView[n].SetActive(true);
        nowDiscView = discView[n];
    }
}
