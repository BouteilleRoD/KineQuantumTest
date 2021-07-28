using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Player : MonoBehaviour
{
    float Hdirection, Vdirection;
    float speed = 10f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.right * Hdirection * speed * Time.deltaTime);
        transform.Translate(Vector3.forward * Vdirection * speed * Time.deltaTime);
    }

    public void OnHMovement(InputValue val)
    {
        Hdirection = val.Get<float>();
    }
    public void OnVMovement(InputValue val)
    {
        Vdirection = val.Get<float>();
    }
}
