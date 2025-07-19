using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using Unity.VisualScripting;
using UnityEngine.EventSystems;

public class RegisterPage : MonoBehaviour
{
    [Header("UI 元件")]
    public InputField InputField_email;
    public InputField InputField_pw;
    public InputField inputField_phonenum;
    public Text Warning_1;
    public Text Warning_2;
    public GameObject icon_canLook;
    public GameObject icon_dontLook;

    private bool isPasswordVisible = false;

    public GameObject btn_Register;
    public GameObject errorText;
    public List<Toggle> toggles;

    // 要調整高度的 Panel
    public RectTransform panelRegister;

    [Header("Panel 尺寸設定")]
    public float origianlHeight = 550f;
    public float expandedHeight = 780f;
    private bool isExpanded = false;

    private void Start()
    {
        // 警告文字
        Warning_1.gameObject.SetActive(false);
        Warning_2.gameObject.SetActive(false);

        // 針對 Text 是否已填入字串，加入監聽事件 
        InputField_email.onValueChanged.AddListener(ValidateEmail);
        InputField_pw.onValueChanged.AddListener(ValidatePassword);

        // 初始狀態為遮蔽密碼
        InputField_pw.contentType = InputField.ContentType.Password;
        InputField_pw.ForceLabelUpdate();

        // 密碼的眼睛開闔
        icon_canLook.SetActive(false);
        icon_dontLook.SetActive(true);

        //隱藏註冊按鍵
        btn_Register.SetActive(false);
        errorText.SetActive(true);

        // 針對 Email, Password 是否已填入字串，加入監聽事件 
        InputField_email.onValueChanged.AddListener(delegate { ValidateForm(); });
        InputField_pw.onValueChanged.AddListener(delegate { ValidateForm(); });

        foreach (Toggle t in toggles)
        {
            t.onValueChanged.AddListener(delegate { ValidateForm(); });
        }

        // 設定面板高度 (輸入 Email, Password, Phone Number 文字時, 自動撐開高度)
        SetPanelHeight(origianlHeight);
        InputField_email.onValueChanged.AddListener(OnInputChanged);
        InputField_pw.onValueChanged.AddListener(OnInputChanged);
        inputField_phonenum.onValueChanged.AddListener(OnInputChanged);
    }

    private void Update()
    {
        // 滑鼠點擊(Dev Debug) 或 觸控螢幕點擊 (實體操作)
        if (IsPointDown())
        {
            GameObject selected = EventSystem.current.currentSelectedGameObject;

            if (!IsInputField(selected) && isExpanded && AllInputFieldsEmpty())
            {
                SetPanelHeight(origianlHeight);
                isExpanded = false;
            }
        }
    }

    public void ValidateEmail(string input)
    {
        if (input.Contains("@") && input.Contains("."))
        {
            Warning_1.gameObject.SetActive(false);
        }
        else
        {
            Warning_1.gameObject.SetActive(true);
        }
    }

    public void ValidatePassword(string input)
    {
        if (input.Length >= 8)
        {
            Warning_2.gameObject.SetActive(false);
        }
        else {
            Warning_2.gameObject.SetActive(true);
        }
    }

    public void TogglePasswordVisibility()
    {
        isPasswordVisible = !isPasswordVisible;

        if (isPasswordVisible)
        {
            // 顯示文字字串
            InputField_pw.contentType = InputField.ContentType.Standard;
            icon_canLook.SetActive(true);
            icon_dontLook.SetActive(false);
        }
        else
        {
            // 顯示米字字串
            InputField_pw.contentType = InputField.ContentType.Password;
            icon_canLook.SetActive(false);
            icon_dontLook.SetActive(true);
        }

        // 強制更新 UI 顯示
        InputField_pw.ForceLabelUpdate();
    }

    public void ValidateForm()
    {
        bool hasEmail = !string.IsNullOrEmpty(InputField_email.text);
        bool hasPW = !string.IsNullOrEmpty(InputField_pw.text);
        bool hasToggleChecked = toggles.Exists(t => t.isOn);

        if (hasEmail && hasPW && hasToggleChecked)
        {
            btn_Register.SetActive(true);
            errorText.gameObject.SetActive(false);
        }
        else
        {
            btn_Register.SetActive(false);
            errorText.gameObject.SetActive(true);
        }
    }

    void OnInputChanged(string _)
    {
        if (!isExpanded && ShouldExpand())
        {
            SetPanelHeight(expandedHeight);
            isExpanded = true;
        }
    }

    bool ShouldExpand()
    {
        return !string.IsNullOrEmpty(InputField_email.text) ||
               !string.IsNullOrEmpty(InputField_pw.text) ||
               !string.IsNullOrEmpty(inputField_phonenum.text);
    }

    bool AllInputFieldsEmpty()
    {
        return string.IsNullOrEmpty(InputField_email.text) &&
               string.IsNullOrEmpty(InputField_pw.text) &&
               string.IsNullOrEmpty(inputField_phonenum.text);
    }

    bool IsInputField(GameObject obj)
    {
        if (obj == null) return false;
        return obj.GetComponent<InputField>() != null;
    }

    bool IsPointDown()
    {
        // 支援滑鼠點擊
        if (Input.GetMouseButtonDown(0))
            return true;

        // 支援觸控點擊（僅偵測第一個手指）
        if (Input.touchCount > 0 && Input.GetTouch(0).phase == TouchPhase.Began)
            return true;

        return false;
    }

    void SetPanelHeight(float height)
    {
        Vector2 size = panelRegister.sizeDelta;
        size.y = height;
        panelRegister.sizeDelta = size;
    }

    public void OnClickRegisterBtn_CN()
    {
        SceneManager.LoadScene("letterVerify_CN");
    }
    public void OnClickRegisterBtn_EN()
    {
        SceneManager.LoadScene("letterVerify_EN");
    }
    }
