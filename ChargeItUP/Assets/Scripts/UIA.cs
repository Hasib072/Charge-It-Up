
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIA : MonoBehaviour
{

    public GameObject Plane1;
    public GameObject Battery;
    public GameObject IMG3;
    public GameObject IMG2;
    public GameObject IMG1;
    public GameObject PlayB;
    public GameObject ExitB;
    public GameObject Title;
    public Vector3 TSize;
    public float Vx;
    public float Rx;
    public float Rx2;
    public float Time;





    void Start()
    {
        LeanTween.moveLocalX(Plane1, Vx, Time).setEaseOutElastic();
        LeanTween.rotateZ(Battery, Rx, 1).setLoopPingPong();

        LeanTween.scale(IMG1, TSize, 2).setLoopPingPong();
        LeanTween.scale(IMG2, TSize, 2).setLoopPingPong();
        LeanTween.scale(IMG3, TSize, 2).setLoopPingPong();
        LeanTween.moveLocalX(PlayB, Rx2, 3).setEaseOutElastic();
        LeanTween.moveLocalX(ExitB, Rx2, 3).setEaseOutElastic();
        LeanTween.scale(Title, TSize, 2).setLoopPingPong();



    }

    // Update is called once per frame
    void Update()
    {

    }
}
