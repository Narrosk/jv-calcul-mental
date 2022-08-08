using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//A besoin du Keypad pour fonctionner
public class MineMultiplication : MonoBehaviour
{
    //0 à 11 -> easy; 12 à 23 -> medium; 24 à 35 -> hard
    public (string, string)[] table = new (string, string)[36];
    bool start = false;
    Keypad keypad;

    private void Start()
    {
        keypad = GameObject.FindGameObjectWithTag("keypad").GetComponent<Keypad>();
        GameEvents.current.succeeded1 += NextCalculation;

        //Creation de la table de multiplication
        int i = 0;

        for (int j = 2; j <= 9; j++)
        {
            for (int k = j; k <= 9; k++)
            {
                table[i] = (j.ToString() + "x" + k.ToString(), (j * k).ToString());
                i++;
            }
        }
    }

    private void OnMouseDown()
    {
        if (!start)
        {
            start = true;
            NextCalculation();
        }
    }

    void NextCalculation()
    {
        int rnd = Random.Range(0, 36);
        keypad.CurrentCalcul = table[rnd].Item1;
        keypad.Goal = table[rnd].Item2;
    }
}
