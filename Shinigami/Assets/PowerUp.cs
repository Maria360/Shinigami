using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUp : MonoBehaviour
{
    //public GameObject destroyPS;
    public GameObject idlePS;
    private void Start()
    {
        idlePS.SetActive(true);
        //destroyPS.SetActive(false);
    }
    public void Destroy()
    {
        //destroyPS.SetActive(true);
        idlePS.SetActive(false);
    }
    
}
