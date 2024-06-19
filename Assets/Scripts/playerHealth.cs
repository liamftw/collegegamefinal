using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class playerHealth : MonoBehaviour
{
    public int clydeHealth;
    public int clydeHeartNum;

    public Image[] clydeHearts;
    public Sprite fullHeart;
    public Sprite emptyHeart;

    void Update()
    {
        if (clydeHealth > clydeHeartNum)
        {
            clydeHealth = clydeHeartNum;
        }

        if (clydeHealth == 0)
        {
            SceneManager.LoadScene("LoseScreen");
        }

        for (int i = 0; i < clydeHearts.Length; i++)
        {
            if (i < clydeHealth)
            {
                clydeHearts[i].sprite = fullHeart;
                clydeHearts[i].enabled = true;
            }
            else
            {
                clydeHearts[i].sprite = emptyHeart;
                clydeHearts[i].enabled = false;
            }
        }
    }
}
