using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Parallax : MonoBehaviour
{
    [SerializeField] Camera cam;
    [SerializeField] Transform player;


    Vector2 startPosition;
    float startZ;


    float distanceFromSubject => transform.position.z - player.position.z;
    float clippingPlane => (cam.transform.position.z + (distanceFromSubject > 0 ? cam.farClipPlane : cam.nearClipPlane));
    public float parallaxFactor => Mathf.Abs(distanceFromSubject) / clippingPlane;
    Vector2 travel => (Vector2)cam.transform.position - startPosition;
    private void Start()
    {
        startPosition = transform.position;
        startZ = transform.position.z;
    }
    private void FixedUpdate()
    {
        Vector2 newpos = startPosition + travel * parallaxFactor;
        transform.position = new Vector3(newpos.x, newpos.y, startZ);
    }
   
}
