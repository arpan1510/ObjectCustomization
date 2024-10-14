using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class restartExit : MonoBehaviour
{
    // restarts application
    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    // exits application
    public void ExitGame()
    {
        Application.Quit();
    }
}
