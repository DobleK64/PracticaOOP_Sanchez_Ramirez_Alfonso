using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    public bool inCombat;
    public string playerClass;
    public string playerName;
    public GameObject playerCharacter;
    public LevelManager levelManager;
    public UIManager uiManager;
    private void Awake()
    {
        if (Instance == null)
            Instance = this;
        else
            Destroy(this.gameObject);
        DontDestroyOnLoad(gameObject);
    }
    public void startGM()
    {
        levelManager = GameObject.Find("LevelManager").GetComponent<LevelManager>();
        uiManager = GameObject.Find("Canvas").GetComponent<UIManager>();
        inCombat = false;
        playerCharacter = GameObject.Find("Player");
        switch (playerClass)
        {
            case "cowboy":
                if (playerCharacter != null)
                {
                    playerCharacter.AddComponent<Cawboy>();
                    playerCharacter.GetComponent<Cawboy>().constructor(playerName, 10, levelManager.sprites[0]);
                    playerCharacter.GetComponent<PlayerMove>().setSprite(playerCharacter.GetComponent<Cawboy>().GetSprite());
                }
                break;
            case "wizard":
                if (playerCharacter != null)
                {
                    playerCharacter.AddComponent<Wizard>();
                    playerCharacter.GetComponent<Wizard>().constructor(playerName, 5, 2,levelManager.sprites[1]);
                    playerCharacter.GetComponent<PlayerMove>().setSprite(playerCharacter.GetComponent<Wizard>().GetSprite());
                }
                break;
        }
    }
    public void restart()
    {
        inCombat = false;
        uiManager.combateUI.SetActive(false);
    }
}
