using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GravityController : MonoBehaviour
{
    private Rigidbody rb;
    public GameObject cylinder;
    // Start is called before the first frame update
    void Start()
    {
        rb= GetComponent<Rigidbody>();
    }

    public void OnCollisionEnter(Collision hit)
    {
        if (hit.gameObject.name == "cylinder")
        {
            gameObject.GetComponent<Rigidbody>().isKinematic= false;
        }
    }
}
