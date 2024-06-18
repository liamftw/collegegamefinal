using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BackButton : MonoBehaviour
{
    void Start()
    {
        StartCoroutine(BackButtonCoroutine());
    }

    private IEnumerator BackButtonCoroutine()
    {
        yield return new WaitForSeconds(4f);

        SceneManager.LoadScene("Menu");
    }
}
