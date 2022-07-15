using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnnemyController : MonoBehaviour
{
    public float speed = 1f;
    public string result { get; private set; } //A choisir au hasard dans un fichier de données
    public string calcul { get; private set; }

    Rigidbody2D rb;
    Vector3 positionInitiale;
    EnnemyController himself;

    bool isSelected = false;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        himself = GetComponent<EnnemyController>();

        positionInitiale = transform.position;
        int rnd = Random.Range(0, 36);
        calcul = TableMultiplication.current.table[rnd].Item1;
        result = TableMultiplication.current.table[rnd].Item2;
    }

    private void FixedUpdate()
    {
        rb.MovePosition(rb.position + Vector2.down * speed * Time.deltaTime);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        //ATTAQUE DE LA VILLE
        //transform.position = positionInitiale;
        gameObject.SetActive(false);
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
            GameEvents.current.EnnemyHasChanged();
        }
    }

    public void Die()
    {
        gameObject.SetActive(false);
    }

    public void Deselect() => isSelected = false;
}
