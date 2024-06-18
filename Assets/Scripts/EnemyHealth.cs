using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EnemyHealth : MonoBehaviour
{
    public int enemyHealth = 3;


    public void EnemyDamage (int damage)
    {
        enemyHealth -= damage;

        if (enemyHealth <= 0)
        {
            SceneManager.LoadScene("WinScreen");
        }
    }
}
