using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class SwitchLevelButton : MonoBehaviour, IPointerClickHandler
{
    public void OnPointerClick(PointerEventData data)
    {
        int nextLevel = LevelManager.curLevel == 1 ? 2 : 1;
        Debug.Log($"Switch to level {nextLevel}");
        LevelManager.GoToLevel(nextLevel);
    }
}
