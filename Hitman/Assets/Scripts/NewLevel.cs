using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadNewLevel : MonoBehaviour
{
    public int numOfLevels = 3;

    [SerializeField]
    GameObject NewLevelScreen;

    public void LoadNL()
    {
        int nextSceneIndex = SceneManager.GetActiveScene().buildIndex + 1;
        if (nextSceneIndex == numOfLevels) nextSceneIndex = 0;

        //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        SceneManager.LoadScene(nextSceneIndex);
        NewLevelScreen.SetActive(false);
        
    }
}
