using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Asteroids", menuName = "AsteroidsObject", order = 1)]
public class Asteroids : ScriptableObject
{
    [Header("Base Informations")]
    public string nameAsteroid;
    public Mesh mesh;
    public Material material;
    public float size;
    public float damages;

    [Space, Header("In game")]
    public float speed;
    public float spawnRatePerSeconds;
    public float timeBeforeStartToSpawn;
    public float TimeStayToSpawn;
    public bool destroyProtection;

    [Space, Header("Dead")]
    public GameObject particuleCollideProtection;
}
