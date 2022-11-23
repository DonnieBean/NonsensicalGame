using NonsensicalKit;
using NonsensicalKit.Manager;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class InitSceneManager : NonsensicalMono
{
    private void Awake()
    {
        Subscribe((int)NonsensicalManagerEnum.AllInitCompleted, OnLoadComplete);
    }

    private void OnLoadComplete()
    {
        SceneManager.LoadSceneAsync("MainMenuScene", LoadSceneMode.Single);
    }
}
