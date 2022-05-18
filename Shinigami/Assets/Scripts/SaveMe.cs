using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveMe : MonoBehaviour
{
    bool canDo = true;
    void Start()
    {
        if(canDo)
        {
            DontDestroyOnLoad(gameObject);
        }
    }
    private void Update()
    {
        if(gameObject.scene.name == "Homescreen")
        {
            canDo = false;
        }
    }

}
