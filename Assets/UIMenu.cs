using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class UIMenu : MonoBehaviour
{
    public TMP_InputField nameP;
    public TMP_Dropdown clase;
    
    public void UpdateData()
    {
        GameManager.Instance.playerName = nameP.text;
        GameManager.Instance.playerClass = clase.options[clase.value].text;
    }
    public void loadLevel()
    {
        SceneManager.LoadScene(1);
    }
}
