using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boundaries : MonoBehaviour
{
    //creator name--bhuvaneshwaran.p, this one for IDZ private Lmt., Date (06/01/2023) 

    // Update is called once per frame
    void Update()
    {
        //Player Bountry Line
        transform.position = new Vector3(Mathf.Clamp(transform.position.x, -2.34f, 2.34f),
            Mathf.Clamp(transform.position.y, -4.50f, 3.65f),transform.position.z);
        
    }
}
