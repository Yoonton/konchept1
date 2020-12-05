using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeLvl : MonoBehaviour
{
    public GameObject OldLvl;
    public GameObject NewLvl;
    void Start()
    {
        OldLvl.SetActive(false);
        NewLvl.SetActive(true);
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse1))
        {
            OldLvl.SetActive(true);
            NewLvl.SetActive(false);
        }
        if(Input.GetKeyDown(KeyCode.Mouse0))
        {
            OldLvl.SetActive(false);
            NewLvl.SetActive(true);
        }
    }
}
