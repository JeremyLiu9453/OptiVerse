using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class APP_Function : MonoBehaviour
{
    [Header("APP Function Button")]
    public AppFunctionButtons AppButtons;

    // btn_Home
    public void Go_Home_CN() { SceneManager.LoadScene("HomePage_CN"); }
    public void Go_Home_EN() { SceneManager.LoadScene("HomePage_EN"); }

    // btn_Course
    public void Go_Course_CN() { SceneManager.LoadScene("CoursePage_CN"); }
    public void Go_Course_EN() { SceneManager.LoadScene("CoursePage_EN"); }

    // btn_Ovira
    public void Go_Ovira_CN() { SceneManager.LoadScene("OviraAI_CN"); }
    public void Go_Ovira_EN() { SceneManager.LoadScene("OviraAI_EN"); }

    // btn_User
    public void Go_User_CN() { SceneManager.LoadScene("UserPage_CN"); }
    public void Go_User_EN() { SceneManager.LoadScene("UserPage_EN"); }

}

[System.Serializable]
public class AppFunctionButtons
{
    public Button HomeButton;
    public Button CourseButton;
    public Button OviraAIButton;
    public Button UserButton;
}
