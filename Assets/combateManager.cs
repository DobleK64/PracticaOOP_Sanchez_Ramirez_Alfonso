using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class combateManager : MonoBehaviour
{
    private Character player;
    private Character enemigo;

    public void setNewCombat(Character _player, Character _enemigo)
    {
        Debug.Log("newCombat");
        player = _player;
        enemigo = _enemigo;
        UpdateUICombat();
    }
    public bool newAccion(int id)
    {
        switch (id)
        {
            case 0:
                enemigo.health -= player.Attack();
                GameManager.Instance.uiManager.UpdatePlayerEstado("Atake: " + player.Attack());
                enemigoAccion();
                break;
            case 1:
                player.Heal();
                GameManager.Instance.uiManager.UpdatePlayerEstado("heal: " + player.Heal());
                enemigoAccion();
                break;
        }
        UpdateUICombat();
        if (player.health <= 0 || enemigo.health <= 0)
            return true;
        else
            return false;
    }
    private void enemigoAccion()
    {
        int temp = Random.Range(0,2);
        switch (temp)
        {
            case 0:
                player.health -= enemigo.Attack();
                GameManager.Instance.uiManager.UpdateEnemigoEstado("Atake: " + enemigo.Attack());
                break;
            case 1:
                enemigo.Heal();
                GameManager.Instance.uiManager.UpdateEnemigoEstado("heal: " + enemigo.Heal());
                break;
        }
    }
    private void UpdateUICombat()
    {
        GameManager.Instance.uiManager.UpdateUI(player.health.ToString(),enemigo.health.ToString(),player.nameCharacter,enemigo.nameCharacter);
    }
}
