using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;

[AddComponentMenu("My components/Stairs")]
public class Stairs : MonoBehaviour
{
    
    //public int numOfLevels = 3;

    [SerializeField]
    GameObject NewLevelScreen;

    void OnTriggerEnter(Collider myCollider) {
        if (myCollider.tag == ("Character")) {

            NewLevelScreen.SetActive(true);

            //int nextSceneIndex = SceneManager.GetActiveScene().buildIndex + 1;
            //if (nextSceneIndex == numOfLevels) nextSceneIndex = 0;

            //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
            //SceneManager.LoadScene (nextSceneIndex);
        }
    }
}
