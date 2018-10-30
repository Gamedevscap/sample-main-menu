﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MenuManager : MonoBehaviour {

    public void StartScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }

	public void ExitGame()
    {
        Application.Quit();
    }
}
