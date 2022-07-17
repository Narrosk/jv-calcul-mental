using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerScript : MonoBehaviour
{
    public GameObject ennemy;
    [SerializeField] Transform parent;

    float yBoundary = 5.2f;
    bool enCours = false;

    void Start()
    {
        GameEvents.current.clickOnPlay += StartSpawning;
        GameEvents.current.clickOnStop += StopSpawning;
        GameEvents.current.clickOnResume += ResumeSpawning;
        GameEvents.current.clickOnReturnVillage += StopAll;
    }

    void StartSpawning()
    {
        if (!enCours)
        {
            StartCoroutine(Spawn());
        }
    }

    void StopSpawning() => enCours = false;
    void ResumeSpawning() => enCours = true;
    void StopAll() => StopAllCoroutines();

    IEnumerator Spawn()
    {
        enCours = true;

        int nbEnnemy = Random.Range(4, 7);
        int i = 0;
        while (i < nbEnnemy)
        {
            //A modifier pour que la vague reprenne 1s après la pause ?
            if (enCours) //Si le joueur n'a pas fait pause durant la vague
            {
                float rnd = Random.Range(-2f, 2f);
                Instantiate(ennemy, new Vector3(rnd, yBoundary), ennemy.transform.rotation, parent); //Remplacer par du ObjectPoooling
                i++;

                yield return new WaitForSeconds(Random.Range(0.5f, 3f));
            }
            else
                yield return null; 
        }

        enCours = false;
    }
}
