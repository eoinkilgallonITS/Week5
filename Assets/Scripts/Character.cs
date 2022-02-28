using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{
    public int MaxHealth;
    public int health;

    public int MaxAmmo;
    public int Ammo;

    public GameObject Bullet;
    public virtual void OnCharacterDeath()
    {
        Debug.Log("Character Death");
    }

    public virtual void FireWeapon()
    {

    }
}
