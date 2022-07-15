using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnnemyManager : MonoBehaviour
{
    //Permet que tout le monde puisse accéder à l'ennemi en cours
    public static EnnemyManager current;
    public EnnemyController currentEnnemy;

    private void Start()
    {
        current = this;
    }
}
