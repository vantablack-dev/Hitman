using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NewLevel1 : MonoBehaviour
{
    public int numOfLevels = 3;

    [SerializeField]
    GameObject NewLevelScreen;

    void LoadNewLevel()
    {
        int nextSceneIndex = SceneManager.GetActiveScene().buildIndex + 1;
        if (nextSceneIndex == numOfLevels) nextSceneIndex = 0;

        //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        SceneManager.LoadScene(nextSceneIndex);
        NewLevelScreen.SetActive(false);
        
    }
}
