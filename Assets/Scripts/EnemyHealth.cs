using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class EnemyHealth : MonoBehaviour
{
    public int enemyHealth = 3;

    public Text enemyHealthText;

    void Start()
    {
        UpdateHealthText();
    }

    public void EnemyDamage(int damage)
    {
        enemyHealth -= damage;

        if (enemyHealth <= 0)
        {
            SceneManager.LoadScene("WinScreen");
        }
        UpdateHealthText(); // Update the UI Text after taking damage
    }

    void UpdateHealthText()
    {
        if (enemyHealthText != null)
        {
            enemyHealthText.text = "Enemy Health: " + enemyHealth.ToString();
        }
    }
}
