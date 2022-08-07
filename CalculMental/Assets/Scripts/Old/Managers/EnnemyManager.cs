using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnnemyManager : MonoBehaviour
{
    //Permet que tout le monde puisse accéder à l'ennemi en cours
    public static EnnemyManager current;
    public EnnemyController currentEnnemy;
    public int[] nbEchec = new int[36]; //Indique pour chaque calcul le nb d'échec
    public int[] nbReussite = new int[36];

    private void Start()
    {
        current = this;
    }
}
