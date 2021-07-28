using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Turret : MonoBehaviour
{

    public GameObject Target;
    public GameObject Projectile;
    private GameObject _children;


    Vector3 targetDirection;
    Vector3 shootingDirection;
    
    
    float shotPower = 100f;
    float cd = 1f;
    float lastshotTimer;
    float shotRange = 40f;
    float detectionRange = 80f;
    
    // Start is called before the first frame update
    void Start()
    {
        _children = GameObject.FindGameObjectWithTag("Canon");
    }

    // Update is called once per frame
    void Update()
    {
        if (Target == null)
        {
            RaycastHit[] rch = Physics.SphereCastAll(transform.position, detectionRange, transform.forward, 10f);
            for (int i = 0; i < rch.Length; i++)
            {
                if (rch[i].transform.gameObject.CompareTag("Player"))
                {
                    Target = rch[i].transform.gameObject;
                }
            }
        }
        else
        {
            targetDirection.x = Target.transform.position.x - transform.position.x;
            targetDirection.y = Target.transform.position.y - transform.position.y;
            targetDirection.z = Target.transform.position.z - transform.position.z;
            if (Vector3.Distance(Target.transform.position, transform.position) > detectionRange)
            {
                Target = null;
            }
            if (Vector3.Distance(Target.transform.position, transform.position) < shotRange)
            {
                if (Time.time - lastshotTimer > cd) 
                {
                    Shoot();

                }
            }
            _children.transform.forward = targetDirection;
        }
    }
    public void Shoot()
    {
        //TODO Implement Shoot
        Debug.Log("Shot ! ");
        GameObject bullet = Instantiate(Projectile, _children.transform.position + 4 * _children.transform.forward, new Quaternion(0f, 0f, 0f, 0f));
        shootingDirection = targetDirection + transform.position - (_children.transform.position + 4 * _children.transform.forward);
        bullet.GetComponent<Rigidbody>().AddForce(shootingDirection * shotPower);
        lastshotTimer = Time.time;
    }

   
}
