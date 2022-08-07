using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerScript : MonoBehaviour
{
    [SerializeField] Transform parent;
    [SerializeField] List<GameObject> ennemies;

    float yBoundary = 5.2f;
    bool enCours = false;
    int nbEasy;
    int nbMedium;
    int nbHard;
    int nbDead = 0;


    void Start()
    {
        OldGameEvents.current.clickOnPlay += StartSpawning;
        OldGameEvents.current.clickOnStop += StopSpawning;
        OldGameEvents.current.clickOnResume += ResumeSpawning;
        OldGameEvents.current.clickOnReturnVillage += StopAll;
        OldGameEvents.current.ennemyHasDied += CountDeadEnnemy;
    }

    void StartSpawning()
    {
        if (!enCours)
        {
            Debug.Log("Debut");
            enCours = true;
            nbEasy = Random.Range(1, 4);  
            nbMedium = Random.Range(1, 3);
            nbHard = Random.Range(1, 3);

            StartCoroutine(Spawn(nbEasy, 0));
            StartCoroutine(Spawn(nbMedium, 5));
            StartCoroutine(Spawn(nbHard, 10));
        }
    }

    void StopSpawning() => enCours = false;
    void ResumeSpawning() => enCours = true;
    void StopAll() => StopAllCoroutines();

    IEnumerator Spawn(int nbEnnemy, int start)
    {
        int i = 0;
        while (i < nbEnnemy)
        {
            //A modifier pour que la vague reprenne 1s après la pause ?
            if (enCours) //Si le joueur n'a pas fait pause durant la vague
            {
                float rnd = Random.Range(-2f, 2f);
                ennemies[i+start].transform.position = new Vector3(rnd, yBoundary);
                ennemies[i+start].SetActive(true);
                i++;

                yield return new WaitForSeconds(Random.Range(0.5f, 3f));
            }
            else
                yield return null; 
        }
    }

    void CountDeadEnnemy()
    {
        nbDead++;
        if (nbDead >= nbEasy + nbMedium + nbHard)
        {
            enCours = false;
            OldGameEvents.current.FinVague();
            nbDead = 0;
        }
    }
}
