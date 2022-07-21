using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Gère le menu pause et les vagues d'ennemies
public class UIMenu : MonoBehaviour
{
    public void Play()
    {
        GameEvents.current.HasClickedOnPlay();
    }

    public void Stop()
    {
        GameEvents.current.HasClickedOnStop();
    }

    public void Resume()
    {
        GameEvents.current.HasClickedOnResume();
    }

    public void ReturnVillage()
    {
        GameEvents.current.HasClickedOnReturnVillage();
    }
}
