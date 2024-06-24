using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseMov : MonoBehaviour
{
    // Start is called before the first frame update
    
    public float sensitivity;
    float rotationX = 0f;
    float rotationY = 0f;
    public Transform orientation;
    
   
    

    void Start()
        
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
        
       
        
    }

    // Update is called once per frame
    void Update()
    {
        float mouseX = Input.GetAxisRaw("Mouse X") * Time.deltaTime * sensitivity;
        float mouseY = Input.GetAxisRaw("Mouse Y") * Time.deltaTime * sensitivity;

        rotationY += mouseX;
        rotationX -= mouseY;

        rotationX = Mathf.Clamp(rotationX, -90f, 90f);

        transform.rotation = Quaternion.Euler(rotationX, rotationY, 0);
        orientation.rotation = Quaternion.Euler(0, rotationY, 0);

        
        
    }
}
