using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class SwitchSceneButton : MonoBehaviour, IPointerClickHandler
{
    public void OnPointerClick(PointerEventData data)
    {
        int nextLevel = LevelManager.curLevel == 1 ? 2 : 1;

        LevelManager.GoToLevel(nextLevel);
    }
}