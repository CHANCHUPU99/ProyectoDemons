using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurretManager : MonoBehaviour {
    float timeToShoot = 2;
    float timer;
    
    [SerializeField] float force = 5f;
    [SerializeField] GameObject enemy;
    [SerializeField] GameObject bullet;
    Rigidbody m_rigidBody;

    private void OnTriggerEnter(Collider other) {
        if (other.CompareTag("Enemy")) {
           StartCoroutine (Shoot());
        }
    }
    IEnumerator Shoot() {
        while (true) {
            yield return new WaitForSeconds(timeToShoot);
            Instantiate(bullet, transform.position, Quaternion.identity);
        }
    }

}
