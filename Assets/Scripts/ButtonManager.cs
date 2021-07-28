using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonManager : MonoBehaviour
{
    public GameObject settingsPanel;
    public GameManager GM;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Settings()
    {
        settingsPanel.SetActive(true);
    }

    public void Restart()
    {
        GameObject[] Trash = GameObject.FindGameObjectsWithTag("Respawn");
        foreach(GameObject g in Trash)
        {
            Destroy(g.gameObject);
        }
        GM.resetCubes();
        GM.Start();
    }

    public void Close()
    {
        settingsPanel.SetActive(false);
    }
}
