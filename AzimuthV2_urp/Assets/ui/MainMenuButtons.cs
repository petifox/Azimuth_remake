using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuButtons : MonoBehaviour
{
    public Animator transAnim;
    public float transTime = 1f;

    [SerializeField]
    public static MainMenuButtons instance;

    private void Awake()
    {
        instance = this;
    }
    public void PlayButton()
    {
        StartCoroutine(TransitionToNextScene(transTime));
    }

    IEnumerator TransitionToNextScene(float time)
    {
        transAnim.SetTrigger("Start");
        yield return new WaitForSeconds(time);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    public void QuitGame()
    {
        Application.Quit();
        Debug.Log("QUIT!");
    }
}
