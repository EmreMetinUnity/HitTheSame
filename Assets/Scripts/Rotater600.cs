using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotater600 : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0f, 600f * Time.deltaTime, 0, Space.Self);
    }
}
