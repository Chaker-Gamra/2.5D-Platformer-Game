using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAttacks : MonoBehaviour
{
    public void Attack(int damageAmount)
    {
        PlayerManager.currentHealth -= damageAmount;
    }
}
