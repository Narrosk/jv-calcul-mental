using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerScript : MonoBehaviour
{
    public GameObject ennemy;
    public float attente = 1.5f;
    float yBoundary = 5.2f;

    void Start()
    {
        StartCoroutine(Spawn());
    }

    IEnumerator Spawn()
    {
        while (true)
        {
            float rnd = Random.Range(-2f, 2f);
            Instantiate(ennemy, new Vector3(rnd, yBoundary), ennemy.transform.rotation);

            yield return new WaitForSeconds(attente);
        }
    }
}
