using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeenAnima : MonoBehaviour
{
    private GameObject Cell1;
    private GameObject Cell2;
    private GameObject Cell3;
    private GameObject Cell4;
    private GameObject Cell5;
    private GameObject CamJ;
    
    private float t = 3;
    public float y;
    
    void Start()
    {
        Cell1 = GameObject.Find("Cell1");
        Cell2 = GameObject.Find("Cell2");
        Cell3 = GameObject.Find("Cell3");
        Cell4 = GameObject.Find("Cell4");
        Cell5 = GameObject.Find("Cell5");
        CamJ = GameObject.Find("CamJ");

        

        LeanTween.rotateY(CamJ, 75, t).setEaseInOutCubic().setLoopPingPong();
        LeanTween.rotateY(Cell1, y, Random.Range(1, 4)).setLoopPingPong();
        LeanTween.moveLocalY(Cell1, 4, Random.Range(1, 4)).setLoopPingPong();
        LeanTween.rotateY(Cell2, y, Random.Range(1, 4)).setLoopPingPong();
        LeanTween.moveLocalY(Cell2, 4, Random.Range(1, 4)).setLoopPingPong();
        LeanTween.rotateY(Cell3, 200, Random.Range(1, 4)).setLoopPingPong();
        LeanTween.moveLocalY(Cell3, 4, Random.Range(1, 4)).setLoopPingPong();
        LeanTween.rotateY(Cell4, y, Random.Range(1, 4)).setLoopPingPong();
        LeanTween.rotateY(Cell5, y, Random.Range(1, 4)).setLoopPingPong();
        


    }

    
    void Update()
    {
        
    }
}
