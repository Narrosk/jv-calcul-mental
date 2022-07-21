using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Transformer en scriptableObject ?
public class TableMultiplication : MonoBehaviour
{
    public static TableMultiplication current;
    //0 à 11 -> easy; 12 à 23 -> medium; 24 à 35 -> hard
    public (string, string)[] table = new (string, string)[36];
    

    private void Start()
    {
        current = this;

        //Creer la table de multiplication
        int i = 0;

        for (int j = 2; j <= 9; j++)
        {
            for (int k = j; k <= 9; k++)
            {
                table[i] = (j.ToString() + "x" + k.ToString(), (j*k).ToString());
                i++;
            }
        }
    }
}
