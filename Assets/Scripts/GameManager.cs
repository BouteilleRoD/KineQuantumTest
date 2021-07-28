using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    private int cubeNumber = 50;
    public GameObject Cube;

    int nbBorder = 10;
    List<GameObject> _cubes = new List<GameObject>();
    GameObject[] _border;
    bool needtoadd = true;
    // Start is called before the first frame update
    public void Start()
    {
        Debug.Log("Cubes : " + cubeNumber);
        nbBorder = (int)cubeNumber * 20 / 100;
        _border = new GameObject[nbBorder];
        for (int i = 0; i < cubeNumber; i++)
        {
            float X = Random.Range(0, 100f);
            float Z = Random.Range(0, 100f);
            GameObject tmp = Instantiate(Cube, new Vector3(X, 0.5f, Z), new Quaternion(0f, 0f, 0f, 0f));
            _cubes.Add(tmp);
            if(i < nbBorder)
            {
                _border[i] = tmp;
            }
        }
        Vector3 barycentre = new Vector3(0f, 0f, 0f);
        foreach(GameObject c in _cubes)
        {
            barycentre.x += c.transform.position.x;
            barycentre.z += c.transform.position.z;
        }
        barycentre = barycentre / cubeNumber;
        foreach(GameObject c in _cubes)
        {
            int j = nbBorder - 1;
            while(Vector3.Distance(c.transform.position, barycentre) < Vector3.Distance(_border[j].transform.position, barycentre))
            {
                j--;
                if (j < 0) 
                {
                    needtoadd = false;
                    break;
                }
                else
                {
                    needtoadd = true;
                }

            }
            if(needtoadd) _border[j] = c;
        }
        foreach(GameObject bd in _border)
        {
            bd.GetComponent<MeshRenderer>().material = Resources.Load("ShootingAreaMat") as Material;
        }
    }

    // Update is called once per frame
    void Update()
    {
           
    }
    
    public void SetcubeNumber(string i)
    {
        cubeNumber = System.Convert.ToInt32(i);
        Debug.Log("Number of cubes = " + System.Convert.ToInt32(i));
    }

    public void resetCubes()
    {
        _cubes.Clear();
    }
}
