using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class OviraChat_UIBtn : MonoBehaviour
{
    [Header("UI Conpoent")]
    public RectTransform page_ChatOVI;
    public Button navPanelBtn, navPanelBtnClicked;
    public GameObject pageChat2TouchArea;

    private Vector2 originPos = new Vector2(-157.81f, 0f);
    private Vector2 navPanelPos = new Vector2(156.83f, 0f);
    private bool isPage_ChatOVI_Toggled = false;

    void Start()
    {
        navPanelBtn.onClick.AddListener(OnNavBtnClicked);
        navPanelBtnClicked.onClick.AddListener(OnNavBtnClickedBack);
        navPanelBtn.gameObject.SetActive(true);
        navPanelBtnClicked.gameObject.SetActive(false);
    }

    public void OnNavBtnClicked()
    {
        page_ChatOVI.anchoredPosition = navPanelPos;
        isPage_ChatOVI_Toggled = true;

        // 切換按鈕狀態
        navPanelBtn.gameObject.SetActive(false);
        navPanelBtnClicked.gameObject.SetActive(true);
    }

    public void OnNavBtnClickedBack()
    {
        page_ChatOVI.anchoredPosition = originPos;
        isPage_ChatOVI_Toggled = false;

        // 切換按鈕狀態
        navPanelBtn.gameObject.SetActive(true);
        navPanelBtnClicked.gameObject.SetActive(false);
    }

    void Update()
    {
        if (isPage_ChatOVI_Toggled && Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);
            if (touch.phase == TouchPhase.Began)
            {
                if (RectTransformUtility.RectangleContainsScreenPoint(
                    pageChat2TouchArea.GetComponent<RectTransform>(),
                    touch.position,
                    Camera.main))
                {
                    // 移回原位
                    page_ChatOVI.anchoredPosition = originPos;
                    isPage_ChatOVI_Toggled = false;

                    // 按鈕狀態同步還原
                    navPanelBtn.gameObject.SetActive(true);
                    navPanelBtnClicked.gameObject.SetActive(false);
                }
            }

        }
    }
}
