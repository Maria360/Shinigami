using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamaraFollow : MonoBehaviour
{
    public GameObject follow;
    public Vector2 minCampPos, maxCamPos;
    public float smoothTime;

    private Vector2 velocity;
    

    void FixedUpdate()
    {
        float posX = Mathf.SmoothDamp(transform.position.x, follow.transform.position.x, ref velocity.x, smoothTime);
        float posY = Mathf.SmoothDamp(transform.position.y, follow.transform.position.y, ref velocity.y, smoothTime);

        transform.position = new Vector3(
            Mathf.Clamp(posX, minCampPos.x, maxCamPos.x),
            Mathf.Clamp(posY, minCampPos.y, maxCamPos.y),
            transform.position.z);
    }
}
