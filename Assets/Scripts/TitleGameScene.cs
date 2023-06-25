using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TitleGameScene : MonoBehaviour
{
    public void GameScenesCtrl()
    {
        SceneManager.LoadScene("InGame_Main");
        Debug.Log("게임 씬 이동");
    }

    public void GameOverScenesCtrl()
    {
        SceneManager.LoadScene("GameOver");
        Debug.Log("게임 종료 씬 이동");
    }
}
