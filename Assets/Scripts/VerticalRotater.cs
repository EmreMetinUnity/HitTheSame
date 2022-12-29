using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VerticalRotater : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        transform.Rotate(400f * Time.deltaTime, 0f, 0, Space.Self);
    }
}
