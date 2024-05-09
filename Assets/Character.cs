using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Character : MonoBehaviour
{
    public string nameCharacter;
    public float health;
    protected float damage;
    protected float jumpForce;
    public Sprite _sprite;

    public Character(string name, float damage, Sprite sprite)
    {
        this.nameCharacter = name;
        this.damage = damage;
        _sprite = sprite;
    }

    public Sprite GetSprite() { return _sprite; }

    public float GetDamage(){ return damage; }

    public abstract float Attack();

    public virtual float Heal()
    {
        Debug.Log("Character se cura");
        health = Mathf.Clamp(health, 0, 100);
        return health;
    }
}

