using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Roof : MonoBehaviour
{
    public Transform[] lamps;
    public Material lamp_off;
    // Start is called before the first frame update
    void Start()
    {
        foreach(Transform lamp in lamps) 
        {
            if(Random.Range(0, 6) == 1) 
            {
                lamp.GetComponentInChildren<Light>().gameObject.SetActive(false);
                lamp.GetComponent<Renderer>().material = lamp_off;
            }
        }
    }
}
