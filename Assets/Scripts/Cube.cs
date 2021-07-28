using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour
{
    GameObject targetPlane;
    Vector3 shotDirection;
    // Start is called before the first frame update
    void Start()
    {
        targetPlane = GameObject.Find("TargetArea");
        shotDirection = targetPlane.transform.position - transform.position;
        shotDirection.y = 0f;
        shotDirection.x *= 5f * Mathf.Abs(transform.position.x);
        shotDirection.z *= 5f * Mathf.Abs(transform.position.z);
        GetComponent<Rigidbody>().AddForce(shotDirection);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
