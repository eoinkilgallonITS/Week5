using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : Character
{
    public GameObject ExplosionPrefab;
    void Start()
    {
        //Invoke("OnCharacterDeath", 5);
    }

    
    void Update()
    {
        
    }

    public override void OnCharacterDeath()
    {
        Instantiate(ExplosionPrefab, transform.position, Quaternion.identity);
        Destroy(gameObject);
        base.OnCharacterDeath();
    }
}
