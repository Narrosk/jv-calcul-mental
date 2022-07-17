using System.Collections;
using System;
using UnityEngine;

public class GameEvents : MonoBehaviour
{
    public static GameEvents current;

    private void Awake()
    {
        current = this;
    }
    
    public event Action ennemyHasChanged;
    public void EnnemyHasChanged()
    {
        if (ennemyHasChanged != null)
            ennemyHasChanged();
    }

    //Juste donner une référence au Spawner ?
    public event Action clickOnPlay;
    public void HasClickedOnPlay()
    {
        if (clickOnPlay != null)
            clickOnPlay();
    }

    public event Action clickOnStop;
    public void HasClickedOnStop()
    {
        if (clickOnStop != null)
            clickOnStop();
    }

    public event Action clickOnResume;
    public void HasClickedOnResume()
    {
        if (clickOnResume != null)
            clickOnResume();
    }

    public event Action clickOnReturnVillage;
    public void HasClickedOnReturnVillage()
    {
        if (clickOnReturnVillage != null)
            clickOnReturnVillage();
    }
}
