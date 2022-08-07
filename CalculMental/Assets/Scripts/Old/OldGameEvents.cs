using System.Collections;
using System;
using UnityEngine;

public class OldGameEvents : MonoBehaviour
{
    public static OldGameEvents current;

    private void Awake()
    {
        current = this;
    }

    public event Action ennemyHasDied;
    public void EnnemyHasDied()
    {
        if (ennemyHasDied != null)
            ennemyHasDied();
    }

    public event Action ennemyHasChanged;
    public void EnnemyHasChanged()
    {
        if (ennemyHasChanged != null)
            ennemyHasChanged();
    }

    public event Action finVague;
    public void FinVague()
    {
        if (finVague != null)
            finVague();
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
