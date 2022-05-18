using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Laser : MonoBehaviour
{
    public Transform firepoint;
    public GameObject laserPrefab;
    float timer = 0f;

    void Update()
    {
        timer += Time.deltaTime;
        if (timer >= 3f)
        {
            Instantiate(laserPrefab, firepoint.position, firepoint.rotation);
            timer = 0f;
        }

    }
    


}
