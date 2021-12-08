using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreGoal : MonoBehaviour
{

    public AirHockeyScript hockey;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "BlueGoal")
        {
            hockey.IncrementBlue();
        }
        else if (collision.gameObject.tag == "RedGoal")
        {
            hockey.IncrementRed();
        }
    }

}
