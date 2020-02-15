using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    public int healthPoints = 3;
    public int score = 0;

    //Debug
    public GameObject gameInfo;

    void Update()
    {
        if(healthPoints <= 0)
        {
            SceneManager.LoadScene("MenuScene", LoadSceneMode.Single);
        }
    }

    public void Hit(GameObject gameObject, string color)
    {
        Debug.Log("Hit");

        if (gameObject.transform.parent.GetComponent<Obstacle>().GetColor().Equals(color))
        {
            Debug.Log("Right Color");

            score += 1;

            gameInfo.GetComponent<GameDebug>().UpdateTextToHit();
            gameInfo.GetComponent<GameDebug>().UpdateScore(score);
        }
        else if (!gameObject.transform.parent.GetComponent<Obstacle>().GetColor().Equals(color))
        {
            Debug.Log("Wrong Color, reducing health points by 1");

            healthPoints = healthPoints - 1;

            gameInfo.GetComponent<GameDebug>().UpdateTextToMiss();
            gameInfo.GetComponent<GameDebug>().UpdateHP(healthPoints);
        }
    }
}
