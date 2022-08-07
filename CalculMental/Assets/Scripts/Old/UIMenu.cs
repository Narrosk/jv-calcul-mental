using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Gère le menu pause et les vagues d'ennemies
public class UIMenu : MonoBehaviour
{
    public void Play()
    {
        OldGameEvents.current.HasClickedOnPlay();
    }

    public void Stop()
    {
        OldGameEvents.current.HasClickedOnStop();
    }

    public void Resume()
    {
        OldGameEvents.current.HasClickedOnResume();
    }

    public void ReturnVillage()
    {
        OldGameEvents.current.HasClickedOnReturnVillage();
    }
}
