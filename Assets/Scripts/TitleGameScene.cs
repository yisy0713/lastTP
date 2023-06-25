using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TitleGameScene : MonoBehaviour
{
    public void GameScenesCtrl()
    {
        SceneManager.LoadScene("InGame_Main");
        Debug.Log("∞‘¿” æ¿ ¿Ãµø");
    }

    public void GameOverScenesCtrl()
    {
        Application.Quit();
    }
}
