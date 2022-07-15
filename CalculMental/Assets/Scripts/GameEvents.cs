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
        {
            ennemyHasChanged();
        }
    }
}
