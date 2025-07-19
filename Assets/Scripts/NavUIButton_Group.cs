using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NavUIButton_Group : MonoBehaviour
{
    [Header("New Chat Buttons")]
    public Button NewChat_Ori, NewChat_Clicked;

    [Header("Chapter")]
    public Button Chapter_Ori, Chapter_Clicked;

    [Header ("History")]
    public Button History_Ori, History_Clicked;

    void Start()
    {
        // NewChat
        NewChat_Ori.gameObject.SetActive (true);
        NewChat_Clicked.gameObject.SetActive (false);

        // Chapter 
        Chapter_Ori.gameObject .SetActive (true);
        Chapter_Clicked.gameObject .SetActive (false);

        // History
        History_Ori.gameObject .SetActive (true);
        History_Clicked.gameObject .SetActive (false);

        // AddListener
        //NewChat_Ori.onClick.AddListener(() => ToggleButtonGroup(NewChat_Ori, NewChat_Clicked));
        //Chapter_Ori.onclick.AddListener(() => ToggleButtonGroup(Chapter_Ori, Chapter_Clicked));
        //History_Ori.onclick.AddListener(() => ToggleButtonGroup(History_Ori, History_Clicked));
    }

    // NewChat
    public void On_NewChat_Ori()
    {
        NewChat_Ori.gameObject.SetActive(true);
        NewChat_Clicked.gameObject.SetActive(false);
        Chapter_Ori.gameObject.SetActive(true);
        Chapter_Clicked.gameObject.SetActive(false);
        History_Ori.gameObject.SetActive(true);
        History_Clicked.gameObject.SetActive(false);
    }
    public void On_NewChat_Clicked()
    {
        NewChat_Ori.gameObject.SetActive(false);
        NewChat_Clicked.gameObject.SetActive(true);
        Chapter_Ori.gameObject.SetActive(true);
        Chapter_Clicked.gameObject.SetActive(false);
        History_Ori.gameObject.SetActive(true);
        History_Clicked.gameObject.SetActive(false);
    }

    // Chapter
    public void On_Chapter_Ori()
    {
        NewChat_Ori.gameObject.SetActive(true);
        NewChat_Clicked.gameObject.SetActive(false);
        Chapter_Ori.gameObject.SetActive(true);
        Chapter_Clicked.gameObject.SetActive(false);
        History_Ori.gameObject.SetActive(true);
        History_Clicked.gameObject.SetActive(false);
    }
    public void On_Chapter_Clicked()
    {
        NewChat_Ori.gameObject.SetActive(true);
        NewChat_Clicked.gameObject.SetActive(false);
        Chapter_Ori.gameObject.SetActive(false);
        Chapter_Clicked.gameObject.SetActive(true);
        History_Ori.gameObject.SetActive(true);
        History_Clicked.gameObject.SetActive(false);
    }

    // History
    public void On_History_Ori()
    {
        NewChat_Ori.gameObject.SetActive(true);
        NewChat_Clicked.gameObject.SetActive(false);
        Chapter_Ori.gameObject.SetActive(true);
        Chapter_Clicked.gameObject.SetActive(false);
        History_Ori.gameObject.SetActive(true);
        History_Clicked.gameObject.SetActive(false);
    }
    public void On_History_Clicked() 
    {
        NewChat_Ori.gameObject.SetActive(true);
        NewChat_Clicked.gameObject.SetActive(false);
        Chapter_Ori.gameObject.SetActive(true);
        Chapter_Clicked.gameObject.SetActive(false);
        History_Ori.gameObject.SetActive(false);
        History_Clicked.gameObject.SetActive(true);
    }
}
