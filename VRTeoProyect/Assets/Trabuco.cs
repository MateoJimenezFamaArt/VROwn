using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trabuco : MonoBehaviour
{
    [Header("Bullet Settings")]
    [SerializeField] private GameObject bulletPrefab; // Prefab de la bala
    [SerializeField] private Transform spawnPoint; // Punto donde se spawnará la bala
    [SerializeField] private float bulletSpeed = 20f; // Velocidad de la bala

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Puedes llamar a SpawnBullet aquí o en otra lógica
        if (Input.GetKeyDown(KeyCode.Space)) // Ejemplo: disparar al presionar la barra espaciadora
        {
            SpawnBullet();
        }
    }

    /// <summary>
    /// Spawnea una bala en el punto especificado.
    /// </summary>
    public void SpawnBullet()
    {
        GameObject bullet = Instantiate(bulletPrefab, spawnPoint.position, spawnPoint.rotation);
        Rigidbody rb = bullet.GetComponent<Rigidbody>();
        if (rb != null)
        {
            rb.velocity = spawnPoint.forward * bulletSpeed; // Disparar la bala hacia adelante
        }
    }
}
