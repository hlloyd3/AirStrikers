using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AirHockeyScript : MonoBehaviour
{
    public Text BlueScoreText, RedScoreText;
    private int blueScore, redScore;

    public enum Score
    {
        BlueScore, RedScore
    }

    public void Increment(Score whichScore)
    {
        if (whichScore == Score.BlueScore)
        {
            BlueScoreText.text = (++blueScore).ToString();
        }
        else
        {
            RedScoreText.text = (++redScore).ToString();
        }
    }
}
