using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Map_Show : MonoBehaviour
{

    public GameObject keys;
    public GameObject map;
    public bool key_Show;
    public bool map_Show;
    public bool TaskCompleted;

    public static bool game_Finished;

    // Start is called before the first frame update
    void Start()
    {
        key_Show = false;
        keys.SetActive(false);
        map.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        //TaskCompleted = Task_Display.game_Finished;
        if (Input.GetKeyDown(KeyCode.H))
        {
            if(key_Show == true)
            {
                keys.SetActive(true);
                key_Show = false;
            }
            else
            {
                keys.SetActive(false);
                key_Show = true;
            }
        }

        if (Input.GetKeyDown(KeyCode.M))
        {
            if (map_Show == true)
            {
                map.SetActive(true);
                map_Show = false;
            }
            else
            {
                map.SetActive(false);
                map_Show = true;
            }
        }

        if (Input.GetKeyDown(KeyCode.P))
        {
            TaskCompleted = true;
            SceneManager.LoadScene(0);
        }

    }
}
