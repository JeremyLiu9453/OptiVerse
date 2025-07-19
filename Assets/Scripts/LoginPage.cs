using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LoginPage : MonoBehaviour
{
    [Header("UI 元件")]
    // 開發者預設信箱
    public string emailAddress = "liujeremy321@gmail.com";

    public static class SceneNavigator
    {
        // 登入選單
        public static void LoadLoginMenuCN()
        {
            SceneManager.LoadScene("LoginMenu_CN");
        }

        public static void LoadLoginMenuEN()
        {
            SceneManager.LoadScene("LoginMenu_EN");
        }

        // 登入頁面 (On-Boarding)
        public static void LoadOnBoardingCN()
        {
            SceneManager.LoadScene("OnBoarding01_CN");
        }
        public static void LoadOnBoardingEN()
        {
            SceneManager.LoadScene("OnBoarding01_EN");
        }

        // 註冊頁面
        public static void LoadRegisterCN()
        {
            SceneManager.LoadScene("RegisterPage_CN");
        }

        public static void LoadRegisterEN()
        {
            SceneManager.LoadScene("RegisterPage_EN");
        }
    }

    // 加載登入頁面 (中/英)
    public void GoToLoginMenuCN()
    { 
        SceneNavigator.LoadLoginMenuCN();
    }
    public void GOTOLoginMenuEN()
    { 
        SceneNavigator.LoadLoginMenuEN();
    }

    // 加載 On-Boarding APP 特色介紹 (中/英)
    public void GoToOnBoardingCN()
    {
        SceneNavigator.LoadOnBoardingCN();
    }
    public void GoToOnBoardingEN()
    {
        SceneNavigator.LoadOnBoardingEN();
    }

    // 加載註冊頁面 (中/英)
    public void GoToRegisterCN()
    {
        SceneNavigator.LoadRegisterCN();
    }
    public void GoToRegisterEN()
    {
        SceneNavigator.LoadRegisterEN();
    }

    // 請求協助? 直接聯繫開發者吧!
    public void OpenMailApp()
    {
        // 使用 mailto 協定打開預設郵件應用程式
        string mailto = $"mailto:{emailAddress}";
        Application.OpenURL(mailto);
    }

}
