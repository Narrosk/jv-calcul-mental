using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

//Chargé de faire réapparaitre le bouton Play à la fin d'une vague
public class PlayVagueButton : MonoBehaviour
{
    Image image;

    void Start()
    {
        GameEvents.current.finVague += ShowButton;
        image = GetComponent<Image>();
    }

    void ShowButton()
    {
        image.enabled = true;
    }
}
