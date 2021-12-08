using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AirHockeyScript : MonoBehaviour
{
    public Text BlueScoreText, RedScoreText;
    public int blueScore, redScore;

    public Transform puckSpawnPoint;

    public GameObject puckCurrent;

    public GameObject blueWinScreen;
    public GameObject RedWinScreen;

    private void Update()
    {
        puckCurrent = GameObject.FindGameObjectWithTag("Puck");
        
    }

    public void IncrementBlue()
    {
        BlueScoreText.text = (++blueScore).ToString();
        ResetPuck();
    }

    public void IncrementRed()
    {
        RedScoreText.text = (++redScore).ToString();
        ResetPuck();
    }

    public void ResetPuck()
    {
        puckCurrent.transform.position = puckSpawnPoint.position;
        puckCurrent.GetComponent<Rigidbody>().velocity = new Vector3(0, 0, 0);
        if (blueScore >= 7)
        {
            blueWinScreen.SetActive(true);
            Time.timeScale = 0;
        }
        else if (redScore >= 7)
        {
            RedWinScreen.SetActive(true);
            Time.timeScale = 0;
        }
    }
}
