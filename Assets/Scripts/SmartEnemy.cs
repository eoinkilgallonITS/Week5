using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SmartEnemy : Character
{
    Player playerCharacter;

    public float attackRange = 3;
    RaycastHit2D RaycastHit;
    void Start()
    {
        GameObject player = GameObject.FindGameObjectWithTag("Player");
        playerCharacter = player.GetComponent<Player>();
    }

    void Update()
    {
        if (Vector2.Distance(transform.position, playerCharacter.transform.position) <= attackRange)
        {
            transform.up = playerCharacter.transform.position - transform.position;

            RaycastHit = Physics2D.Raycast(transform.position, transform.up, attackRange);


            if (RaycastHit.collider != null)
            {
                if (RaycastHit.collider.gameObject.CompareTag("Player"))
                {
                    playerCharacter.health -= 1;
                }
            }
        }
        
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.cyan;
        Gizmos.DrawWireSphere(transform.position, attackRange);

        Gizmos.color = Color.red;
        Gizmos.DrawLine(transform.position, transform.position + transform.up * attackRange);
    }
}
