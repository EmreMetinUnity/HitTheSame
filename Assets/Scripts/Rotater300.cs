using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotater300 : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0f, 300f * Time.deltaTime, 0, Space.Self);
    }
}
