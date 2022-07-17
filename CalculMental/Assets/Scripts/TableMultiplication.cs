using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TableMultiplication : MonoBehaviour
{
    //Transformer en scriptableObject
    public static TableMultiplication current;
    public (string, string)[] table = new (string, string)[36];
   /* [HideInInspector]
    public List<int> easy = new List<int>(); //Contient le numéro de tous les calculs jugés "faciles"
    public List<int> medium = new List<int>();
    public List<int> hard = new List<int>();*/

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
                //medium.Add(i);
                i++;
            }
        }
    }
}
