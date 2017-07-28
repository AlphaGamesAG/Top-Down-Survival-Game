using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour {
	public void Quit()
    {
        Application.Quit();
    }
    public void LoadLevel(string level)
    {
        SceneManager.LoadScene(level);
    }
}
