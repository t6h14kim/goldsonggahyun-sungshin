using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cshLimit : MonoBehaviour
{
    public int realEvent = 1;
    public int realEvent2 = 0;
    public int realEvent3 = 0;
    //public int temp1 = 1;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y > 1.95) transform.position = new Vector3(transform.position.x,1.95f, transform.position.z);
        if (transform.position.y < 0.5) transform.position = new Vector3(transform.position.x, 0.5f, transform.position.z);
        if (transform.position.x > 9)   transform.position = new Vector3(9, transform.position.y, transform.position.z);
        if (transform.position.x < -10) transform.position = new Vector3(-10, transform.position.y, transform.position.z);
        if (transform.position.z < 1 && transform.position.z > -3.5) realEvent = 1;
        if (transform.position.x < 9 && transform.position.x >-5.5 && transform.position.z>-3.5&& transform.position.z<1 ) realEvent2 = 0;
        if (transform.position.x < 3.9 && transform.position.x > -5.5) realEvent2 =0;
        if (transform.position.x <-5.5 && transform.position.x >-10 ) realEvent2 = 1;
        if (transform.position.x < 9 && transform.position.x > 3.9) realEvent2 = 2;
        if (transform.position.x < -5.5 && transform.position.x > -10 && transform.position.z < -3.5 && transform.position.z > -4.5) realEvent3 = 1; else realEvent3 = 0;
        if (transform.position.x < -5.5 && transform.position.x > -10 && transform.position.z < -17.4 && transform.position.z > -18.5) realEvent3 = 1; else realEvent3 = 0;
        if (transform.position.x < -5.5 && transform.position.x > -10 && transform.position.z < -32.8 && transform.position.z > -33.9) realEvent3 = 1; else realEvent3 = 0;
        if (transform.position.x < 9 && transform.position.x > 3.9 && transform.position.z < -10 && transform.position.z > -11) realEvent3 = 2; else realEvent3 = 0;
        if (transform.position.x < 9 && transform.position.x > 3.9 && transform.position.z < -25&& transform.position.z > -26) realEvent3 = 2; else realEvent3 = 0;
        if (transform.position.x < 9 && transform.position.x > 3.9 && transform.position.z < -40 && transform.position.z > -41.1) realEvent3 = 2; else realEvent3 = 0;
        if (realEvent3 == 1 )
        {
            if (transform.position.x > -5.9) transform.position = new Vector3(-5.9f, transform.position.y, transform.position.z);
        } if (realEvent3 == 2 )
        {
            if (transform.position.x < 3.5) transform.position = new Vector3(3.5f, transform.position.y, transform.position.z);
        }// 11 17.4 //4: 18.5 25  ; //  26 32.8   // 33.9 40  //  41.1 47.2 
        if (transform.position.z < -4.5 && transform.position.z >-10) realEvent = 2;
        if (transform.position.z < -11 && transform.position.z > -17.4) realEvent = 3; // 
        if (transform.position.z < -18.5 && transform.position.z > -25) realEvent = 4; // 18.5 25 
        if (transform.position.z < -26 && transform.position.z > -32.8) realEvent = 5; //  26 32.8 
        if (transform.position.z < -33.9 && transform.position.z > -40) realEvent = 6; // 33.9 40
        if (transform.position.z < -41.1 && transform.position.z > -47.2) realEvent = 7; //  41.1 47.2
        if (realEvent == 1 && realEvent2 == 0 )
        {
            
            if (transform.position.z > 1) transform.position = new Vector3(transform.position.x, transform.position.y, 1);
            if (transform.position.z < -3.5) transform.position = new Vector3(transform.position.x, transform.position.y, -3.5f);
           
        }
        if (realEvent == 1 && realEvent2 == 2)
        {
            if (transform.position.z > 1) transform.position = new Vector3(transform.position.x, transform.position.y, 1);
            if (transform.position.z < -3.5) transform.position = new Vector3(transform.position.x, transform.position.y, -3.5f);
        }
        if (realEvent == 1 && realEvent2 == 1)
        {
          //  if (transform.position.x > -5) transform.position = new Vector3(-5, transform.position.y, transform.position.z);
            if (transform.position.z > 1) transform.position = new Vector3(transform.position.x, transform.position.y, 1);
            if (transform.position.z < -10) transform.position = new Vector3(transform.position.x, transform.position.y, -10);
          //  if (transform.position.x < -10) transform.position = new Vector3(-10, transform.position.y, transform.position.z);
        }
        if (realEvent == 2 && realEvent2 == 1 )
        {
           // if (transform.position.x > 9) transform.position = new Vector3(9, transform.position.y, transform.position.z);
            if (transform.position.z > 1) transform.position = new Vector3(transform.position.x, transform.position.y, 1);
            if (transform.position.z < -10) transform.position = new Vector3(transform.position.x, transform.position.y, -10);
           // if (transform.position.x < -10) transform.position = new Vector3(-10, transform.position.y, transform.position.z);
        }
        if (realEvent == 2 && realEvent2 == 2)
        {
           // if (transform.position.x > 9) transform.position = new Vector3(9, transform.position.y, transform.position.z);
            if (transform.position.z > -4.5) transform.position = new Vector3(transform.position.x, transform.position.y, -4.5f);
            if (transform.position.z < -17.4) transform.position = new Vector3(transform.position.x, transform.position.y, -17.4f);
          //  if (transform.position.x < -10) transform.position = new Vector3(-10, transform.position.y, transform.position.z);
        }
        if (realEvent == 2 && realEvent2 ==0)
        {
            //if (transform.position.x > 9) transform.position = new Vector3(9, transform.position.y, transform.position.z);
            if (transform.position.z > -4.5) transform.position = new Vector3(transform.position.x, transform.position.y, -4.5f);
            if (transform.position.z < -10) transform.position = new Vector3(transform.position.x, transform.position.y, -10);
           // if (transform.position.x < -10) transform.position = new Vector3(-10, transform.position.y, transform.position.z);
        }
        if (realEvent == 3 && realEvent2 == 0)
        {
            if (transform.position.z > -11) transform.position = new Vector3(transform.position.x, transform.position.y, -11);
            if (transform.position.z < -17.4) transform.position = new Vector3(transform.position.x, transform.position.y, -17.4f);
        } if (realEvent == 4 && realEvent2 == 0)
        {
            if (transform.position.z > -18.5) transform.position = new Vector3(transform.position.x, transform.position.y, -18.5f);
            if (transform.position.z < -25) transform.position = new Vector3(transform.position.x, transform.position.y, -25);
        } if (realEvent == 5 && realEvent2 == 0)
        {
            if (transform.position.z > -26) transform.position = new Vector3(transform.position.x, transform.position.y, -26);
            if (transform.position.z < -32.8) transform.position = new Vector3(transform.position.x, transform.position.y, -32.8f);
        }
        if (realEvent == 6 && realEvent2 == 0)
        {
            if (transform.position.z > -33.9) transform.position = new Vector3(transform.position.x, transform.position.y, -33.9f);
            if (transform.position.z < -40) transform.position = new Vector3(transform.position.x, transform.position.y, -40);
        }
        if (realEvent == 7 && realEvent2 == 0)
        {
            if (transform.position.z > -41.1) transform.position = new Vector3(transform.position.x, transform.position.y, -41.1f);
            if (transform.position.z < -47.2) transform.position = new Vector3(transform.position.x, transform.position.y, -47.2f);
        } //4: 18.5 25  ; //  26 32.8   // 33.9 40  //  41.1 47.2 
        if (realEvent == 3 && realEvent2 == 2)
        {
            if (transform.position.z > -4.5) transform.position = new Vector3(transform.position.x, transform.position.y, -4.5f);
            if (transform.position.z < -17.4) transform.position = new Vector3(transform.position.x, transform.position.y, -17.4f);
        } 
        if (realEvent == 3 && realEvent2 == 1)
        {
            if (transform.position.z > -11) transform.position = new Vector3(transform.position.x, transform.position.y, -11);
            if (transform.position.z < -25) transform.position = new Vector3(transform.position.x, transform.position.y, -25);
        }
        if (realEvent == 4 && realEvent2 == 1)
        {
            if (transform.position.z > -11) transform.position = new Vector3(transform.position.x, transform.position.y, -11);
            if (transform.position.z < -25) transform.position = new Vector3(transform.position.x, transform.position.y, -25);
        }
       
      
        if (realEvent == 5 && realEvent2 == 1)
        {
            if (transform.position.z > -26) transform.position = new Vector3(transform.position.x, transform.position.y, -26);
            if (transform.position.z < -40) transform.position = new Vector3(transform.position.x, transform.position.y, -40);
        } if (realEvent == 6&& realEvent2 == 1)
        {
            if (transform.position.z > -26) transform.position = new Vector3(transform.position.x, transform.position.y, -26);
            if (transform.position.z < -40) transform.position = new Vector3(transform.position.x, transform.position.y, -40);
        }
        if (realEvent == 7 && realEvent2 == 1)
        {
            if (transform.position.z > -41.1) transform.position = new Vector3(transform.position.x, transform.position.y, -41.1f);
            if (transform.position.z < -47.2) transform.position = new Vector3(transform.position.x, transform.position.y, -47.2f);
        }


        if (realEvent == 4 && realEvent2 == 2)
        {
            if (transform.position.z > -18.5) transform.position = new Vector3(transform.position.x, transform.position.y, -18.5f);
            if (transform.position.z < -32.8) transform.position = new Vector3(transform.position.x, transform.position.y, -32.8f);
        } if (realEvent == 5 && realEvent2 == 2)
        {
            if (transform.position.z > -18.5) transform.position = new Vector3(transform.position.x, transform.position.y, -18.5f);
            if (transform.position.z < -32.8) transform.position = new Vector3(transform.position.x, transform.position.y, -32.8f);
        } if (realEvent == 6 && realEvent2 == 2)
        {
            if (transform.position.z > -33.9) transform.position = new Vector3(transform.position.x, transform.position.y, -33.9f);
            if (transform.position.z < -47.2) transform.position = new Vector3(transform.position.x, transform.position.y, -47.2f);
        }if (realEvent == 7 && realEvent2 == 2)
        {
            if (transform.position.z > -33.9) transform.position = new Vector3(transform.position.x, transform.position.y, -33.9f);
            if (transform.position.z < -47.2) transform.position = new Vector3(transform.position.x, transform.position.y, -47.2f);
        }
        
        /*
        // 11 17.4 //4: 18.5 25  ; //  26 32.8   // 33.9 40  //  41.1 47.2 
        if (realEvent == 1 && transform.position.x < -5.5) temp1 = 2;
        if (realEvent == 1 && transform.position.x > -5.5) temp1 = 1;
        if (realEvent == 2 && transform.position.x < -5.5) temp1 = 2;
       // if (realEvent == 2 && transform.position.x > -5.5) temp1 = 2;
        if (realEvent == 2 && transform.position.x > 3.5) temp1 = 4; //3.5 7.5 - temp 2가 된것
        //temp 1에 가면
        if (transform.position.x > -5.5 && temp1 != 2)
        {
            realEvent = 1;  realEvent2 = 1;
        }
        if (transform.position.z < -4) //-3.5
        {
            //2구역
        }
        if (temp1 == 2)
        { // temp1은 위아래1에서-9까지다
            if(transform.position.z > 1)
                    transform.position = new Vector3(transform.position.x, transform.position.y, 1);
            if (transform.position.z < -9)
                transform.position = new Vector3(transform.position.x, transform.position.y, -9f);
        }
        if (temp1 ==2 && transform.position.z < -5)
        { // 2구역에 온것
            realEvent = 2;
            if (transform.position.z > -5)
                transform.position = new Vector3(transform.position.x, transform.position.y, -5);
            if (transform.position.z < -9)
                transform.position = new Vector3(transform.position.x, transform.position.y, -9f);          
        }
      //  if (transform.position.z > -4.5 && transform.position.z < -3) realEvent = 100;
      //  if (transform.position.z > -11 && transform.position.z < -9.5) realEvent = 200; //911.5---

        if (transform.position.z > -3.5) realEvent = 1;
        if (realEvent == 100) {//-9-5
            if (transform.position.x < -10)
                transform.position = new Vector3(-10, transform.position.y, transform.position.z);
            if (transform.position.x > -5.5)
                transform.position = new Vector3(-5.5f, transform.position.y, transform.position.z);
        }
        
    }*/
    }
}