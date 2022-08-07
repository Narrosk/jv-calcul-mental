using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Keypad : MonoBehaviour
{
    string goal = "";
    public string Goal {
        private get { return goal; }
        set
        {
            ChangeCalcul();
            goal = value;
        }
    }      

    public string CurrentCalcul { private get; set; }

    TMP_Text result;
    TMP_Text calcul;
    int len = 0;

    private void Start()
    {
        TMP_Text[] t = GetComponentsInChildren<TMP_Text>();
        result = t[0];
        calcul = t[1];
    }

    public void AddNumber(int number)
    {
        result.text += number;
        len += 1;
        CheckSuccess(); //Faut lui donner le nombre à atteindre
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

    public void RemoveUser()
    {
        result.text = "";
        len = 0;
    }
    
    void ChangeCalcul()
    {
        RemoveUser();
        calcul.text = CurrentCalcul;
    }

    void CheckSuccess()
    {
        if (result.text == goal)
        {
            GameEvents.current.Succeeded();
        }
    }
    /*
    void RemoveAll()
    {
        RemoveUser();
        RemoveCalcul();
    }

    void RemoveCalcul()
    {
        calcul.text = "";
    } */
}
