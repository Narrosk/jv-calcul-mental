using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Compteur1_T : MonoBehaviour
{
    TMP_Text text;
    int compteur;

    private void Start()
    {
        text = GetComponent<TMP_Text>();

        compteur = PlayerPrefs.GetInt("compteur1", 0);
        text.text = compteur.ToString();
    }
}
