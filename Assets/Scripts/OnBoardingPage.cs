using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class OnBoardingPage : MonoBehaviour
{
    // [Header("場景切換按鍵-CN01~07")]
    private Button next01, next02, next03, next04, next05, next06, finish07, return07;
    private Button skip01, skip02, skip03, skip04, skip05, skip06;

    // OnBoarding_CN 
    public void NextTo_02_CN()
    {
        SceneManager.LoadScene("OnBoarding02_CN");
    }
    public void NextTo_03_CN()
    {
        SceneManager.LoadScene("OnBoarding03_CN");
    }
    public void NextTo_04_CN()
    {
        SceneManager.LoadScene("OnBoarding04_CN");
    }
    public void NextTo_05_CN()
    {
        SceneManager.LoadScene("OnBoarding05_CN");
    }
    public void NextTo_06_CN()
    {
        SceneManager.LoadScene("OnBoarding06_CN");
    }
    public void NextTo_07_CN()
    {
        SceneManager.LoadScene("OnBoarding07_CN");
    }
    public void Skip_CN()
    {
        SceneManager.LoadScene("OnBoarding07_CN");
    }

    // Debug
    public void debugTestScene()
    {
        SceneManager.LoadScene("Introduce_I_CN");
    }
    public void Finish_CN()
    {
        SceneManager.LoadScene("HomePage_CN");
    }
    public void Return_CN()
    {
        SceneManager.LoadScene("OnBoarding01_CN");
    }

    /* ---------------------------------------------------------------- */
    
    // OnBoarding_EN
    public void NextTo_02_EN()
    {
        SceneManager.LoadScene("OnBoarding02_EN");
    }
    public void NextTo_03_EN()
    {
        SceneManager.LoadScene("OnBoarding03_EN");
    }
    public void NextTo_04_EN()
    {
        SceneManager.LoadScene("OnBoarding04_EN");
    }
    public void NextTo_05_EN()
    {
        SceneManager.LoadScene("OnBoarding05_EN");
    }
    public void NextTo_06_EN()
    {
        SceneManager.LoadScene("OnBoarding06_EN");
    }
    public void NextTo_07_EN()
    {
        SceneManager.LoadScene("OnBoarding07_EN");
    }
    public void Skip_EN()
    {
        SceneManager.LoadScene("OnBoarding07_EN");
    }
    public void Finish_EN()
    {
        SceneManager.LoadScene("HomePage_EN");
    }
    public void Return_EN()
    {
        SceneManager.LoadScene("OnBoarding01_EN");
    }

}
