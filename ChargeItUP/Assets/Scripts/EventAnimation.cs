using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventAnimation : MonoBehaviour
{
    public Rigidbody player;
    public GameObject MCam;
    public float x;
    public float y;
    public float Time;


    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag != "Floor")
        {
            LeanTween.moveLocalX(MCam, x, Time).setEaseInOutBounce();
            LeanTween.moveLocalX(MCam, y, Time).setEaseInOutBounce();
            print("it Works");
        }
    }

   /* void Update()
    {
        LeanTween.moveLocalX(MCam, x, Time).setEaseInOutBounce();
        LeanTween.moveLocalX(MCam, y, Time).setEaseInOutBounce();
    }
    */
}
