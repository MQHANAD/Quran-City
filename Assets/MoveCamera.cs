using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCamera : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform cameraPostion;

    // Update is called once per frame
    void Update()
    {
        transform.position=cameraPostion.position;
    }
}
