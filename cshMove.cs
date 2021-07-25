using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cshMove : MonoBehaviour
{
  public float speed = -0.01f; 
    // -0.01 Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(speed, 0, 0);
        //  if (transform.position.x > 498) transform.position = new Vector3(498, transform.position.y, transform.position.z); 
        if (transform.position.x < -63.72) transform.position = new Vector3(-42.83f, transform.position.y, transform.position.z);
        if (transform.position.x > -42.82) transform.position = new Vector3(-63.71f, transform.position.y, transform.position.z);
    }
}
