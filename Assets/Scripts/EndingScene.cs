using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndingScene : MonoBehaviour
{
    public void TitleScenesCtrl()
    {
        SceneManager.LoadScene("StartScene");
        Debug.Log("타이틀 씬으로 이동");
    }

}
