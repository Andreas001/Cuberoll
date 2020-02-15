using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameDebug : MonoBehaviour
{
    Text CanRotateText;
    Text LastBlockText;
    Text HPText;
    Text ScoreText;

    public GameObject CanRotate;
    public GameObject LastBlock;
    public GameObject HP;
    public GameObject Score;

    void Start()
    {
        CanRotateText = CanRotate.GetComponent<Text>();
        LastBlockText = LastBlock.GetComponent<Text>();
        HPText = HP.GetComponent<Text>();
        ScoreText = Score.GetComponent<Text>();
    }

    public void UpdateTextToNo()
    {
        CanRotateText.text = "Can Rotate: NO";
    }

    public void UpdateTextToYes()
    {
        CanRotateText.text = "Can Rotate: YES";
    }

    public void UpdateTextToHit()
    {
        LastBlockText.text = "Last Block: Hit";
    }

    public void UpdateTextToMiss()
    {
        LastBlockText.text = "Last Block: Miss";
    }

    public void UpdateHP(int hp)
    {
        HPText.text = "HP: " + hp;
    }

    public void UpdateScore(int score)
    {
        ScoreText.text = "Score: " + score;
    }
}
