using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

//Script qui s'occupe des fonctionnalités du keypad et avertit si le joueur a réussi son calcul
public class ResultsScript : MonoBehaviour
{
    TMP_Text result;
    TMP_Text calcul;
    int len = 0;

    private void Start()
    {
        TMP_Text[] t = GetComponentsInChildren<TMP_Text>();
        result = t[0];
        calcul = t[1];

        GameEvents.current.ennemyHasChanged += ChangeCalcul;
    }

    //Rajoute le numéro sur lequel il a été appuyé
    public void AddNumber(int number)
    {
        result.text += number;
        len += 1;
        CheckSuccess();
    }

    public void Back()
    {
        if (len != 0)
        {
            string after = "";
            for (int i = 0; i < len - 1; i++)
            {
                after += result.text[i];
            }

            result.text = after;
            len -= 1;
        }
    }

    public void Remove()
    {
        result.text = "";
        len = 0;
    }

    void ChangeCalcul()
    {
        Remove();
        calcul.text = EnnemyManager.current.currentEnnemy.calcul;
    }

    void CheckSuccess()
    {
        if (EnnemyManager.current.currentEnnemy != null && result.text == EnnemyManager.current.currentEnnemy.result)
        {
            Remove();
            ReinitialiseCalcul();
            EnnemyManager.current.currentEnnemy.Success();
        }
    }

    void ReinitialiseCalcul()
    {
        calcul.text = "";
    }
}
