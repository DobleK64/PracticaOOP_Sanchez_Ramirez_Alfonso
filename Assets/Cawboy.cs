using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cawboy : Character
{
    
    public Cawboy(string name, float damage) : base(name, damage, Resources.Load<Sprite>("Assets/Img/Cowboy.png")) // construimos padre
    {
    }
    public void constructor(string _name, float _damage,Sprite sprite)
    {
        nameCharacter = _name;
        damage = _damage;
        _sprite = sprite;
        health = 100;
    }
    public override float Attack()
    {
        Debug.Log("Cowboy ataca");
        return Random.Range(damage, damage * 1.5f);
    }

    public override float Heal()
    {
        Debug.Log("cowboy se cura");
        health += 10;
        if (health >= 100)
            health = 100;
        return 10;
    }
}
