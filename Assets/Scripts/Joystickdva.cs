using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Joystickdva : MonoBehaviour
{
    public Transform player;
    public Transform circle;
    public Transform outerCircle;

    public float speed = 5f;
    private bool touchStart = false;

    private Vector2 pointA;
    private Vector2 pointB;

    private void Awake()
    {
        //circle.GetComponent<SpriteRenderer>().enabled = true;
        //outerCircle.GetComponent<SpriteRenderer>().enabled = true;
    }


    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            pointA = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, Camera.main.transform.position.z));

            
            
        }

        if (Input.GetMouseButton(0))
        {
            touchStart = true;
            pointB = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, Camera.main.transform.position.z));
        }
        else
        {
            touchStart = false;
        }

    }

    private void FixedUpdate()
    {
        if (touchStart)
        {
            Vector2 offset = pointB - pointA;
            Vector2 direction = Vector2.ClampMagnitude(offset, 1.0f);
            MoveCharacter(direction * -1);
            
            outerCircle.transform.position +=  new Vector3(0,0,0) * -1;
        }
        
    }


    void MoveCharacter(Vector2 direction)
    {
        player.Translate(direction * speed * Time.deltaTime);
    }

}