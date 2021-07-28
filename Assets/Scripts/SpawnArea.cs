using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnArea : MonoBehaviour
{
    public GameObject Cube;

    int cubeCount = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return))
        {
            float X = Random.Range(-12.5f, 12.5f);
            float Z = Random.Range(-12.5f, 12.5f);
            Instantiate(Cube, new Vector3(X, 5f, Z), new Quaternion(0f, 0f, 0f, 0f));
            cubeCount++;
        }
        if(cubeCount == 20)
        {
            Cube[] Cubes = FindObjectsOfType<Cube>();
            foreach(Cube c in Cubes)
            {
                Destroy(c.gameObject);
                cubeCount = 0;
            }
        }
    }
}
