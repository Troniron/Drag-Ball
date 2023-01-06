using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class NewInputSystem : MonoBehaviour
{
    //creator name--bhuvaneshwaran.p, this one for IDZ private Lmt., Date (06/01/2023) 
    //using inputactionMap
    [SerializeField]
    private InputAction MouseTouch;
    private Camera Maincamera;
  private  float StartingPoint;
    private Vector3 Setvelocity = Vector3.zero;
    private WaitForFixedUpdate waitforfixed = new WaitForFixedUpdate();
    [SerializeField]
    private float MouseNormalldrag=0.1f;
  
    // Start is called before the first frame update
  private   void Awake()
    {
        //camera acces start in awake function
        Maincamera = Camera.main;
        
    }
    private void OnEnable()
    {
        //it active mouse touch
        MouseTouch.Enable();
        MouseTouch.performed += Pressed;
    }
    private void OnDisable()
    {//inactive the mouse touch
        MouseTouch.Disable();
        MouseTouch.performed -= Pressed;
    }
    private void Pressed(InputAction.CallbackContext context)
    {
        Ray ray = Maincamera.ScreenPointToRay(Mouse.current.position.ReadValue());
        RaycastHit2D Hit=Physics2D.GetRayIntersection(ray);
        //It collaited start the action    
        if (Hit.collider != null&&Hit.collider.CompareTag("DragObject"))
            {
            StartCoroutine(DraggingObgect(Hit.collider.gameObject));
             }
           


    }
    private IEnumerator DraggingObgect(GameObject Obgect)
    {
        //calculate the distance clicked obgect to maincamera position (same)
        StartingPoint = Vector3.Distance(Obgect.transform.position, Maincamera.transform.position);
      
      
        while (MouseTouch.ReadValue<float>() != 0)
        {
            Ray ray = Maincamera.ScreenPointToRay(Mouse.current.position.ReadValue());
           //smooth dump is decress and increse & the poit current or From the point 
            Obgect.transform.position = Vector3.SmoothDamp(Obgect.transform.position, ray.GetPoint(StartingPoint),ref Setvelocity , MouseNormalldrag);
             yield return null; 
            
        }
    }
  


}
