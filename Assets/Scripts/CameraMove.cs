using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UIElements;

public class CameraMove : MonoBehaviour
{
    public float camForwardSpeed = 10;
    void Update()
    {

        if(Variables.firstTouch == 1)
        {
            transform.position += new Vector3(0, 0, camForwardSpeed * Time.deltaTime);
        }
    }

    public void CamForwardSpeed()
    {
        camForwardSpeed = 0.8f;
    }
}
