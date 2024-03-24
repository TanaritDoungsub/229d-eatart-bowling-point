using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public Text MyscoreText;
    private int ScoreNum;

    void Start()
    {
        ScoreNum = 0;
        MyscoreText.text = "Score : " + ScoreNum;
    }

    private void OnTriggerEnter(Collider Item)
    {
        if (Item.tag == "Item")
        {
            ScoreNum += 1;
            Destroy(Item.gameObject);
            MyscoreText.text = "Score : " + ScoreNum;
        }
    }
}
