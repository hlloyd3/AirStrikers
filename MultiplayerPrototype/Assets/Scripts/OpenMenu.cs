using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenMenu : MonoBehaviour
{

    public GameObject escapeMenu;
    private bool isActive;

    private void Update()
    {
        escapeMenu.SetActive(isActive);
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            isActive = !isActive;
        }
    }

}
