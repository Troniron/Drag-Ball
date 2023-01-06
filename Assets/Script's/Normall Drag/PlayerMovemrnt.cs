using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovemrnt : MonoBehaviour
{
   
    Vector3 Mouseoffset;
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private Vector3 GetMouseworldposition()
    {
        return Camera.main.ScreenToWorldPoint(Input.mousePosition);

    }
    private void OnMouseDown()
    {
        Mouseoffset = gameObject.transform.position - GetMouseworldposition();
    }
    private void OnMouseDrag()
    {
        transform.position = GetMouseworldposition() + Mouseoffset;
    }
}
 