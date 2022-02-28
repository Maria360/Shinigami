using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExitTestingAPK : MonoBehaviour
{
    public void Exit()
    {
        Application.Quit();
        Debug.Log("EXIT");
    }
}
