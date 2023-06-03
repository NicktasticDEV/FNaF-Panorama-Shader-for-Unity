using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;
using UnityEngine.EventSystems;


public class CameraMove : MonoBehaviour  
{
    public float moveLimitCam;
    public GameObject moveLeftToggle;
    public GameObject moveRightToggle;
    public float speed;





    private void Start()
    {
        
    }






    private void Update()
    {
       //If left arrow key is pressed, move camera left, else if right arrow pressed, move right. Do not go over the limit
       if (Input.GetKey(KeyCode.LeftArrow))
        {
            if (transform.position.x > -moveLimitCam)
            {
                transform.Translate(Vector3.left * Time.deltaTime * speed);
            }
        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            if (transform.position.x < moveLimitCam)
            {
                transform.Translate(Vector3.right * Time.deltaTime * speed);
            }
        }

    }


}
