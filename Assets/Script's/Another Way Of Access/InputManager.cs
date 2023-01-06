using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class InputManager : MonoBehaviour
{

    [SerializeField]
    private GameObject Player;
  private   Vector3 offset;
    //  [SerializeField]
    //  private float delay=1.0f,clonedelay=0.5f;
    //   [SerializeField]
    //  private Rigidbody2D Handle;
    //  private Rigidbody2D Currentrb;
    //  private SpringJoint2D Currentone;
    private Camera cam;
    // Start is called before the first frame update
    void Start()
    {
        cam = Camera.main;
        
    }

    // Update is called once per frame
    void Update()
    {
        if (!Touchscreen.current.primaryTouch.press.isPressed)
        {
            return;
        }
      
        
        Vector2 touchposition = Touchscreen.current.primaryTouch.position.ReadValue();
         offset = cam.ScreenToWorldPoint(touchposition);
       Player.transform.position = offset;
      //  Vector2 MouseTouch = Mouse.current.position.ReadValue();
       // Vector3 WorldForMouse = Camera.main.ScreenToWorldPoint(MouseTouch);
      //  Player.transform.position = WorldForMouse;
        
    }
   
    void balls()
    {
      //  Currentrb.isKinematic = false;
      //  Currentrb = null;
      //  Invoke(nameof(detachBall), clonedelay);


    }
    void detachBall()
    {
       // Currentone.enabled = false;
     //   Currentone=null;
        //Invoke(nameof(instiate), delay);
    }
    void instiate()
    {
       // GameObject Instance = Instantiate(Player, transform.position, Quaternion.identity);
       // Currentrb = Instance.GetComponent<Rigidbody2D>();

    }
}
