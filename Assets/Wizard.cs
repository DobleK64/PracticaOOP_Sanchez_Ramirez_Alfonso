using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wizard : Character
{
    private float damageMultipler;
    public Wizard(string name, float damage) : base(name, damage, Resources.Load<Sprite>("Assets/Img/Cowboy.png")) // construimos padre
    {
    }
    public void constructor(string _name, float _damage,float _dangeMultipler, Sprite sprite)
    {
        nameCharacter = _name;
        damage = _damage;
        damageMultipler = _dangeMultipler;
        _sprite = sprite;
        health = 100;
    }
    public override float Attack()
    {
        Debug.Log("wizard ataca");
        return damage * damageMultipler;
    }

    public override float Heal()
    {
        Debug.Log("wizard se cura");
        float temp = Random.Range(damage, damage * damageMultipler);
        health +=  temp;
        if (health >= 100)
            health = 100;
        return temp;
    }
}
