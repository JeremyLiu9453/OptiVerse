using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class letterVerificationPage : MonoBehaviour
{
    public Button returnLogin;
    public GameObject BlackMask;
    public GameObject sendTime;

    private void Start()
    {
        BlackMask.gameObject.SetActive(false);
        sendTime.gameObject.SetActive(false);
    }

    public void OnClickReturnLoginBtn_CN()
    {
        SceneManager.LoadScene("LoginMenu_CN");
    }

    public void OnClickReturnLoginBtn_EN()
    {
        SceneManager.LoadScene("LoginMenu_EN");
    }
}
