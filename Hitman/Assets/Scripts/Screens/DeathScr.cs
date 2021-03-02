using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class DeathScr : MonoBehaviour
{
    [SerializeField]
    GameObject DeathScreen;

    public void RestartAvterDeath()
    {
        DeathScreen.SetActive(false);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}