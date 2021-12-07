using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Starter
{
    [RuntimeInitializeOnLoadMethod(RuntimeInitializeLoadType.AfterSceneLoad)]
    static void OnAfterSceneLoadRuntimeMethod()
    {
        Scene scene = SceneManager.GetActiveScene();
        Debug.Log($"Scene {SceneManager.GetActiveScene().name} has been loaded");

        LevelManager.GoToLevel(1);
    }
}
