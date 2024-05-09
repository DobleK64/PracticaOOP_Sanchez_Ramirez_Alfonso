using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UIManager : MonoBehaviour
{
    public GameObject combateUI;
    public TextMeshProUGUI vida;
    public TextMeshProUGUI vidaEnemigo;
    public TextMeshProUGUI nombre;
    public TextMeshProUGUI nombreEnemigo;
    public TextMeshProUGUI estado;
    public TextMeshProUGUI estadoenemigo;

    public void UpdateUI(string _vida,string _vidaEnemigo,string _nombre,string _nombreEnemigo)
    {
        vida.text = "Vida: " + _vida + "/100";
        vidaEnemigo.text = "Vida: " + _vidaEnemigo + "/100";
        nombre.text = _nombre;
        nombreEnemigo.text = _nombreEnemigo;
    }
    public void UpdatePlayerEstado(string _estado)
    {
        estado.text = _estado;
    }
    public void UpdateEnemigoEstado(string _estado)
    {
        estadoenemigo.text = _estado;
    }
}
