using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Splash : MonoBehaviour
{
    private void Start()
    {
        StartCoroutine(LoadMainMenuAfterDelay());
    }
      
    IEnumerator LoadMainMenuAfterDelay()
    {
        yield return new WaitForSeconds(2f);
        GameManager.Instance.LoadScene("MainMenu");
    }
}
