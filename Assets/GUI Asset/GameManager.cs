using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject panelPause;
    public GameObject pauseButton;

    public void PauseControl()
    {
        if (Time.timeScale == 1){
            panelPause.SetActive (true);
            pauseButton.SetActive (false);
            Time.timeScale = 0;
         } else {
            Time.timeScale = 1;
            panelPause.SetActive (false);
            pauseButton.SetActive (true);
         }
    }

    public void Restart()
    {
        SceneManager.LoadScene (SceneManager.GetActiveScene().buildIndex);
        Time.timeScale = 1;
    }

    public void MenuUtama()
    {
        Application.LoadLevel(0);
    }

    public void NextLevel()
    {
        SceneManager.LoadScene("Level2");
        Time.timeScale = 1;
    }

    public void NextLevel3()
    {
        SceneManager.LoadScene("Level3");
        Time.timeScale = 1;
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
