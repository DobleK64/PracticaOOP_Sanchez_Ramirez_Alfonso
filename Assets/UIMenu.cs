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
        GameManager.Instance.playerName = nameP.text; //Para colocar el nombre
        GameManager.Instance.playerClass = clase.options[clase.value].text; //para elegir entre las clases
    }
    public void loadLevel()
    {
        SceneManager.LoadScene(1);
    }
}
