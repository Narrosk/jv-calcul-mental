using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "newEnnemyData", menuName = "Data/Ennemy")]
public class EnnemyData : ScriptableObject
{
    public float speed;
    public int difficulty; //entre 0 et 2
}
