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
        shotDirection = shotDirection.normalized;
        shotDirection.x = (targetPlane.transform.position.x - transform.position.x);
        shotDirection.z = (targetPlane.transform.position.z - transform.position.z);
        GetComponent<Rigidbody>().AddForce(shotDirection, ForceMode.Impulse);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
