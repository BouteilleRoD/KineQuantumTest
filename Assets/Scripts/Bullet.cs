using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    float lifeTime = 3f;
    float apparitionTime;
    // Start is called before the first frame update
    void Start()
    {
        apparitionTime = Time.time;
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time - apparitionTime > lifeTime)
        {
            Destroy(gameObject);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Collide with : " + collision.gameObject.name);
        if (collision.gameObject.CompareTag("Player"))
        {
            Destroy(gameObject);
        }
    }
}
