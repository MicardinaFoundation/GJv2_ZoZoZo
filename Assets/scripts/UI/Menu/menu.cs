using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class menu : MonoBehaviour
{
    public void Play(int lev)
    {
        SceneManager.LoadScene(lev);
    }

    public void Exit()
    {
        Application.Quit();
        Debug.Log("� ���������");
    }
}
