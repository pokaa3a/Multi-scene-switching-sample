using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public static class SceneHelper
{
    public static void LoadScene(string scene, bool additive = true)
    {
        SceneManager.LoadScene(
            scene, additive ? LoadSceneMode.Additive : 0);
    }

    public static void UnloadScene(string scene)
    {
        SceneManager.UnloadSceneAsync(scene);
    }
}
