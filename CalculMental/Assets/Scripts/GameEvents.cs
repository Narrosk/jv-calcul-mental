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

    public event Action succeeded1;
    public void Succeeded1()
    {
        if (succeeded1 != null)
            succeeded1();
    }
}
