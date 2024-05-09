using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class sukamond : Character
{
    public sukamond(string name, float damage) : base(name, damage, Resources.Load<Sprite>("Assets/Img/Cowboy.png")) // construimos padre
    {
    }
    public void constructor(string _name, float _damage, Sprite sprite)
    {
        nameCharacter = _name;
        damage = _damage;
        _sprite = sprite;
        health = 100;
    }
    public override float Attack()
    {
        float temp = 0;
        if (health < 5)
            temp = 100;
        else
            temp = damage;
        return temp;
    }

    public override float Heal()
    {
        float temp = 0;
        if (health < 5)
            temp = 100;
        else
            temp = damage;
        health += temp / 3;
        return temp;
    }
}
