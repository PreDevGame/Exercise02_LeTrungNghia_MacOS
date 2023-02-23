using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseGame : MonoBehaviour
{
    public GameObject pauseGameUI;
    public GameObject Blocker;
    public AudioSource gameAudio;
    public AudioSource robotVoice;
    public AudioSource clickSound;
    public bool pauseGame = false;

    [Header("Mouse Cursor Settings")]
    public bool cursorLocked = true;
    public bool cursorInputForLook = true;

    void Update()
    {
        if(Input.GetButtonDown("Cancel"))
        {
            SetCursorNone(cursorLocked);
            if (pauseGame == false)
            {
                Time.timeScale = 0;
                Blocker.SetActive(true);
                Blocker.transform.parent = null;
                pauseGame = true;
                gameAudio.Pause();
                robotVoice.Pause();
                pauseGameUI.SetActive(true);
                Cursor.visible = true;
                
            }

            else
            {
                pauseGame = false;
                gameAudio.UnPause();
                robotVoice.UnPause();
                pauseGameUI.SetActive(false);
                Cursor.visible = false;
                Blocker.SetActive(false);
                Time.timeScale = 1;
            }
        }
    }

    private void SetCursorNone(bool newState1)
    {
        Cursor.lockState = newState1 ? CursorLockMode.None : CursorLockMode.Locked;
    }

    private void SetCursorLocked(bool newState2)
    {
        Cursor.lockState = newState2 ? CursorLockMode.Locked : CursorLockMode.None;
    }

    public void ContinueGame()
    {
        clickSound.Play();
        pauseGame = false;
        gameAudio.UnPause();
        robotVoice.UnPause();
        pauseGameUI.SetActive(false);
        Cursor.visible = false;
        SetCursorLocked(cursorLocked);
        Blocker.SetActive(false);
        Time.timeScale = 1;
    }

    public void RestartGame()
    {
        clickSound.Play();
        pauseGame = false;
        gameAudio.UnPause();
        robotVoice.UnPause();
        pauseGameUI.SetActive(false);
        Cursor.visible = false;
        SetCursorLocked(cursorLocked);
        Blocker.SetActive(false);
        GlobalAmmo.theAmmoValue = 0;
        GunFire.theSoliderKilled = 0;
        ScoreUI.theCurrentScore = 0;
        Time.timeScale = 1;
        SceneManager.LoadScene(1);
    }

    public void BackToMenu()
    {
        clickSound.Play();
        pauseGame = false;
        gameAudio.UnPause();
        robotVoice.UnPause();
        pauseGameUI.SetActive(false);
        Cursor.visible = true;
        SetCursorNone(cursorLocked);
        Blocker.SetActive(false);
        Time.timeScale = 1;
        SceneManager.LoadScene(0);
    }
}
