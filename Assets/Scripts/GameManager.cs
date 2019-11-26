using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    int score = 0;
    public Text text;

    

    public void UpdateScore(int points)
    {
        score += points;   
        text.text = ($"score: {score}");
    }

    /*private void OnEnable()
    {
        Player.OnScorePoints += UpdateScore;
    }

    private void OnDisable()
    {
        Player.OnScorePoints -= UpdateScore;
    }*/

}
