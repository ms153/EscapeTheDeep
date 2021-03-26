using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_AI_Disable : MonoBehaviour
{
    public GameObject enemy;

    public float Disable_Time;

    private Enemy_AI enable;

    private bool Fired = false;

    private void Start()
    {
        enable = enemy.GetComponent<Enemy_AI>();
    }

    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Mouse0) && Fired == false)
        {
            enable.AI_Enable = false;
            Invoke("Disable_Enemy", Disable_Time);
            Fired = true;
        }
    }

    private void Disable_Enemy()
    {
        enable.AI_Enable = true;
    }

}