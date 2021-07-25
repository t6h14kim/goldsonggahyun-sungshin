using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cshmove2 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x > 498) transform.position = new Vector3(-6504.9f, transform.position.y, transform.position.z);
        if (transform.position.x < -6504.9) transform.position = new Vector3(498, transform.position.y, transform.position.z);
    }
}
