using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Contient tous les bouts de scripts associés à un bouton autre que le keypad
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
