using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveFelpudo : MonoBehaviour
{
    public Vector3 moveSpeed;
    public float spawnTime = 0.5f;
    public float spawnDelay = 0.5f;
    public Transform alvoFofura;

    void Start()
    {
        moveSpeed = Vector3.right * 0.01f;
        InvokeRepeating("ChangeSpeed", spawnDelay, spawnTime);
    }

    void ChangeSpeed()
    {
        float velocidadeAleatoria = Random.Range(0.5f, 1.5f);
        moveSpeed = new Vector3(velocidadeAleatoria, 0, 0) * 0.01f;
    }

    void Update()
    {
        if (alvoFofura != null)
        {
            float distancia = Vector3.Distance(transform.position, alvoFofura.position);

            if (distancia < 3.0f)
            {
                moveSpeed *= 0.95f;
            }
        }

        transform.position += moveSpeed;
    }
}