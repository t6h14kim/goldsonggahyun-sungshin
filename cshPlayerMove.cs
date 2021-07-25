using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cshPlayerMove : MonoBehaviour
{
    public int IsOn =1;// Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (IsOn == 1)
        {
            transform.Translate(0, 0, 0.1f);
            IsOn = 3;
        }
        if (IsOn == 2)
        {
            transform.Translate(0, 0, -0.1f);
            IsOn = 3;
        }
        if (IsOn == 3)
        {

        }
    }
}
