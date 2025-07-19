using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class OviraIntroducePage : MonoBehaviour
{
    [Header("UI Conponent")]

    // General Button
    public Button btnStart, btnBack, Continue, btnNext, btnCancel;

    // Introduc_I, Introduc_II, Introduc_III, Introduc_IV
    private Button RightPage_I, LeftPage_II, RightPageII, LeftPage_III, RightPageIII, LeftPage_IV;

    public void OnClick_Start() { SceneManager.LoadScene("Introduce_II_CN"); }
    public void OnClick_Back() { SceneManager.LoadScene("Introduce_I_CN"); }
    public void OnClick_Continue() { SceneManager.LoadScene("OviraChat_CN"); }

    // Cancel = close permissions page ; Next = enable system permissions on mobile phone
    public void OnClick_Cancel() { SceneManager.LoadScene("OviraChat_CN"); }

    // II
    public void OnClick_Right_I() { SceneManager.LoadScene("Introduce_III_CN"); }
    // III
    public void OnClick_Left_II() { SceneManager.LoadScene("Introduce_II_CN"); }
    public void OnClick_Right_II() { SceneManager.LoadScene("Introduce_IV_CN"); }
    // IV
    public void OnClick_Left_III() { SceneManager.LoadScene("Introduce_III_CN"); }
    public void OnClick_Right_III() { SceneManager.LoadScene("Introduce_V_CN"); }
    // V
    public void OnClick_Left_IV() { SceneManager.LoadScene("Introduce_IV_CN"); }
}
