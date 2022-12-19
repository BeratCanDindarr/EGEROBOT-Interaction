using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightOpenScript : MonoBehaviour
{
    public GameObject light;
    bool actived = true;
    void Start()
    {
        Opened();
    }

    // Update is called once per frame
    

    void Opened()
    {
        actived = !actived;
        light.active = actived;
    }
}
