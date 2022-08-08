using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

//Compteur pour la ressource 1 liée aux multiplications
public class Compteur1_M : MonoBehaviour
{
    TMP_Text text;
    int compteur;

    private void Start()
    {
        text = GetComponent<TMP_Text>();
        GameEvents.current.succeeded1 += Increase;

        compteur = PlayerPrefs.GetInt("compteur1", 0);
        text.text = compteur.ToString();
    }

    void Increase()
    {
        compteur += 5; //TODO: A faire varier en fonction de la rapidité
        text.text = compteur.ToString();
        PlayerPrefs.SetInt("compteur1", compteur);
    }
}
