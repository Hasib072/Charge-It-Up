using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelLoader : MonoBehaviour
{

    public Animator trans;
    public float Time;
    
    void Start()
    {
        
    }

    
    void Update()
    {
        
    }


    public void ReLoad()
    {
        StartCoroutine(NextLevel(SceneManager.GetActiveScene().buildIndex));
    }


    public void NextLevel() 
    {
        StartCoroutine(NextLevel(SceneManager.GetActiveScene().buildIndex + 1));
    }

    public void ExitGame()
    {
        Application.Quit();
    }

    IEnumerator NextLevel(int LevelIndex)
    {
        trans.SetTrigger("Start");

        yield return new WaitForSeconds(Time);

        SceneManager.LoadScene(LevelIndex);

    }
}
