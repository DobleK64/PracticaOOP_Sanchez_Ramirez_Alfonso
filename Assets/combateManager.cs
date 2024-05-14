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
    public bool newAccion(int id) //Es la accion del personaje
    {
        switch (id)
        {
            case 0:
                enemigo.health -= player.Attack(); //Si el jugador atake el daño que le hace al enemigo
                GameManager.Instance.uiManager.UpdatePlayerEstado("Atake: " + player.Attack());
                enemigoAccion();
                break;
            case 1:
                player.Heal(); //La vida que se cura el jugador
                GameManager.Instance.uiManager.UpdatePlayerEstado("heal: " + player.Heal());
                enemigoAccion();
                break;
        }
        UpdateUICombat();
        if (player.health <= 0 || enemigo.health <= 0) //Actualizamos la vida de cada uno despues de cada turno
            return true;
        else
            return false;
    }
    private void enemigoAccion() //Es la accion del enemigo
    {
        int temp = Random.Range(0,2);
        switch (temp)
        {
            case 0:
                player.health -= enemigo.Attack(); //Si el enemigo ataka el daño que le hace al jugador
                GameManager.Instance.uiManager.UpdateEnemigoEstado("Atake: " + enemigo.Attack());
                break;
            case 1:
                enemigo.Heal(); //Si el enemigo se cura la vida que se cura
                GameManager.Instance.uiManager.UpdateEnemigoEstado("heal: " + enemigo.Heal());
                break;
        }
    }
    private void UpdateUICombat()
    {
        GameManager.Instance.uiManager.UpdateUI(player.health.ToString(),enemigo.health.ToString(),player.nameCharacter,enemigo.nameCharacter);
    }
}
