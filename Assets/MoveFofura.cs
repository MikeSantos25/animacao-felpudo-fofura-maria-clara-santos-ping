using UnityEngine;
using System.Collections;

public class MoveFofura: MonoBehaviour
{
    public Vector3 moveSpeed;
    public float spawnTime = 0.5f;
    public float spawnDelay = 0.5f;
    public Transform alvoFelpudo;

    void Start()
    {
        moveSpeed = Vector3.left * 0.01f;
        InvokeRepeating("ChangeSpeed", spawnDelay, spawnTime);
    }

    void ChangeSpeed()
    {
        float velocidadeAleatoria = Random.Range(-1.5f, -0.5f);
        moveSpeed = new Vector3(velocidadeAleatoria, 0, 0) * 0.01f;
    }

    void Update()
    {
        if (alvoFelpudo != null)
        {
            float distancia = Vector3.Distance(transform.position, alvoFelpudo.position);

            if (distancia < 3.0f)
            {
                moveSpeed *= 0.95f;
        }
        transform.position += moveSpeed;
    }
   }
}