using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class goblin : Character
{
    public goblin(string name, float damage) : base(name, damage, Resources.Load<Sprite>("Assets/Img/Cowboy.png")) // construimos padre
    {
    }
    public void constructor(string _name, float _damage, Sprite sprite)
    {
        nameCharacter = _name;
        damage = _damage;
        _sprite = sprite;
        health = 100;
    }
    public override float Attack() //El saño del goblin y hace el triple de daño cuando esta a menos de 30 de vida
    {
        float temp = 0;
        if (health < 30)
            temp = damage *3;
        else
            temp = damage;
        return temp;
    }

    public override float Heal() // se cura la mitad del daño que hace
    {
        float temp = 0;
        if (health < 30)
            temp = damage *3;
        else
            temp = damage;
        health += temp / 2;
        return temp;
    }
}
