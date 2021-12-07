using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class LevelManager
{
    public static int curLevel = 0;

    public static void GoToLevel(int level)
    {
        if (curLevel != 0)
        {
            SceneHelper.UnloadScene($"Level{curLevel}");
        }

        SceneHelper.LoadScene($"Level{level}");
        curLevel = level;
    }
}
