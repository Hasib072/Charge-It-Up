﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwipeControl : MonoBehaviour
{
    public bool Tap,SwipeU,SwipeD,SwipeR,SwipeL;
    private bool isDraging = false;
    public Vector2 StartTouch, SwipeDelta;
    public Movement Mov;
    private GameObject ScriptBody;


    private void Awake()
    {
        ScriptBody = GameObject.Find("Billy");
        Mov = ScriptBody.GetComponent<Movement>();

    }

    private void Update()
    {
        Tap = SwipeU = SwipeD = SwipeR = SwipeL = false;

        #region StandAlone Inputs
        if (Input.GetMouseButtonDown(0))
            {
                Tap = true;
                isDraging = true;
                StartTouch = Input.mousePosition;
            }
        else if (Input.GetMouseButtonUp(0))
            {
                isDraging = false;
                Reset();
            }
        #endregion

        #region Mobile Input
        if (Input.touches.Length > 0)
        {
            if (Input.touches[0].phase == TouchPhase.Began)
            {
                Tap = true;
                isDraging = true;
                StartTouch = Input.touches[0].position;
            }
            else if (Input.touches[0].phase == TouchPhase.Ended || Input.touches[0].phase == TouchPhase.Canceled)
            {
                isDraging = false;
                Reset();
            }
        }
        #endregion

        SwipeDelta = Vector2.zero;
        if (isDraging)
        {
            if (Input.touches.Length > 0)
            {
                SwipeDelta = Input.touches[0].position - StartTouch;
            }
            else if (Input.GetMouseButtonDown(0))
            {
                SwipeDelta = (Vector2)Input.mousePosition - StartTouch;
            }
        }

        if (SwipeDelta.magnitude > 120)
        {
            float x = SwipeDelta.x;
            float y = SwipeDelta.y;
            if (Mathf.Abs(x) > Mathf.Abs(y))
            {
                //left or right.
                if (x > 0)
                {
                    //Right
                    SwipeR = true;

                    //print("Swiped Right");
                    Mov.MoveRight();
                }
                else if (x < 0)
                {
                    //Left
                    SwipeL = true;
                    
                    //print("Swiped left");
                    Mov.MoveLeft();
                }
                else
                {
                    Mreset();
                }
            }
            else 
            {
                //Up or Down.
                if (y > 0)
                {
                    //UP.
                    SwipeU = true;
                   
                    //print("Swiped up");
                    Mov.MoveForward();
                }
                else if (y < 0)
                {
                    //Down.
                    SwipeD = true;
                    
                    //print("Swiped Down");
                    Mov.MoveBackward();
                }
                else
                {
                    Mreset();
                }
            }

            Reset();
        }
    }

    private void Reset()
    {
        StartTouch = SwipeDelta = Vector2.zero;
        isDraging = false;
        
    }
    private void Mreset() 
    {
        Mov.NOMove();
        
    }


}
