using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class GameController : MonoBehaviour
{
    private void Start()
    {
        Invoke("GoToGameScene",2.0f);
    }
    void GoToGameScene()
    {
        SceneManager.LoadScene(1);
    }
}
