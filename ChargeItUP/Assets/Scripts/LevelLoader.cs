using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelLoader : MonoBehaviour
{

    public Animator trans;
    public float time;
    
    void Start()
    {
        
    }

    
    void Update()
    {
       
    }


    

    public void LoadMenu1()
    {
        StartCoroutine(NextLevel(SceneManager.GetActiveScene().buildIndex - 1));
        Time.timeScale = 1f;

    }

    public void LoadMenu2()
    {
        StartCoroutine(NextLevel(SceneManager.GetActiveScene().buildIndex -2));
        Time.timeScale = 1f;

    }

    public void NextLevel() 
    {
        StartCoroutine(NextLevel(SceneManager.GetActiveScene().buildIndex + 1));
    }


    public void ExitGame()
    {
        Application.Quit();
    }

    public void Pause()
    {
        Time.timeScale = 0f;
    }

    public void Resume()
    {
        Time.timeScale = 1f;
    }

    IEnumerator NextLevel(int LevelIndex)
    {
        trans.SetTrigger("Start");

        yield return new WaitForSeconds(time);

        SceneManager.LoadScene(LevelIndex);

    }

    
}
