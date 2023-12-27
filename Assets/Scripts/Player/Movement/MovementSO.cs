using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "SO/Movement")]
public class MovementSO : ScriptableObject
{
    public float speed;
    public float maxSpeed;
    public float rollingSpeed;
}
