using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CursorSettings : MonoBehaviour
{
   public bool isCursorVisbile = false;
   public bool isCursorLocked = true;

    void Update ()
    {
        Cursor.visible = isCursorVisbile;

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            isCursorLocked = !isCursorLocked;
            isCursorVisbile = !isCursorVisbile;
        }

        if (isCursorLocked == true)
        {
            Cursor.lockState = CursorLockMode.Locked;
        }

        if (isCursorLocked == false)
        {
            Cursor.lockState = CursorLockMode.None;
        }
    }
}
