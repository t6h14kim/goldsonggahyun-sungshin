using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cshCtrl : MonoBehaviour
{
    public float speed = 10.0f;
    public float rotationSpeed = 100.0f;
    void Update()
    {
        
        float h = Input.GetAxis("XboxH");
        float v = Input.GetAxis("XboxV");
        Vector3 direction = new Vector3(h, v, 0.0f);
        transform.Translate(direction * 10.0f * Time.deltaTime);

        if (Input.GetButton("XboxA"))
        {
            transform.Rotate(Vector3.up * 30.0f * Time.deltaTime);
        }
        
        float translation = Input.GetAxis("Vertical") * speed; 
        float translation2 = Input.GetAxis("Horizontal") * speed;
        float rotation = Input.GetAxis("Xbox4") * rotationSpeed;
        float rotation2 = Input.GetAxis("Xbox5") * rotationSpeed; 
        float rotation3 = Input.GetAxis("Xbox4") * rotationSpeed;
        float rotation4 = Input.GetAxis("Xbox5") * rotationSpeed;

        // Make it move 10 meters per second instead of 10 meters per frame...
        translation *= Time.deltaTime; translation2 *= Time.deltaTime;

        rotation *= Time.deltaTime;
        rotation2 *= Time.deltaTime;  rotation3 *= Time.deltaTime;
        rotation4 *= Time.deltaTime;

        // Move translation along the object's z-axis
        transform.Translate(0, 0, translation);
        transform.Translate(translation2, 0, 0);
        // Rotate around our y-axis
        transform.Rotate(0, -rotation, 0);
        transform.Rotate(0, 0, 0);
        transform.Rotate(0, -rotation3, 0);
        transform.Rotate(0, 0, 0);
        if (Input.GetKeyDown("l"))
        print("space key was pressed");
        if (Input.GetKeyDown(KeyCode.Q))
        {
            float rotation5 = rotationSpeed;
            rotation5 *= Time.deltaTime;
            transform.Rotate(0, -rotation5, 0);

            //SceneManager.LoadScene("gsgh");
        }
        if (Input.GetKeyDown(KeyCode.E))
        {
            float rotation6 = rotationSpeed;
            rotation6 *= Time.deltaTime;
            transform.Rotate(0, -rotation6, 0);
        }
    }
}
