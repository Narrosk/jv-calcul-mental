using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnnemyController : MonoBehaviour
{
    public string result { get; private set; }
    public string calcul { get; private set; }
    public EnnemyData data;

    Rigidbody2D rb;
    EnnemyController himself;

    bool isSelected = false;
    int rnd;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        himself = GetComponent<EnnemyController>();
        Reset();
    }

    private void FixedUpdate()
    {
        rb.MovePosition(rb.position + Vector2.down * data.speed * Time.deltaTime);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        //ATTAQUE DE LA VILLE   
        EnnemyManager.current.nbEchec[rnd]++;
        Die();
    }

    //Si l'ennemie a été tué par le joueur
    public void Success()
    {
        EnnemyManager.current.nbReussite[rnd]++;
        Die();
    }

    void Die()
    {
        Reset();
        OldGameEvents.current.EnnemyHasDied();
        gameObject.SetActive(false);
    }

    private void Reset()
    {
        int start = data.difficulty * 12; //0, 12 ou 24
        rnd = Random.Range(start, start+12);
        calcul = TableMultiplication.current.table[rnd].Item1;
        result = TableMultiplication.current.table[rnd].Item2;
    }

    private void OnMouseDown()
    {
        if (!isSelected)
        {
            isSelected = true;
            if (EnnemyManager.current.currentEnnemy != null) //A changer une fois que les ennemis pourront mourir
            {
                EnnemyManager.current.currentEnnemy.Deselect();
            }
            EnnemyManager.current.currentEnnemy = himself;
            OldGameEvents.current.EnnemyHasChanged();
        }
    }

    public void Deselect() => isSelected = false;
}
