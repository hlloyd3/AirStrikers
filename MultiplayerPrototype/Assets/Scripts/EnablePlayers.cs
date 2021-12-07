using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnablePlayers : MonoBehaviour
{

    private void Update()
    {
        GameObject playerObject = GameObject.FindGameObjectWithTag("player");
        playerObject.gameObject.SetActive(true);
    }

}
