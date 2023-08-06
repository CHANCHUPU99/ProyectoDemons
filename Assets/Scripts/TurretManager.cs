using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class TurretManager : MonoBehaviour {
    float timeToShoot = 2;
    float timer;
    
    [SerializeField] float force = 5f;
    [SerializeField] GameObject enemy;
    [SerializeField] GameObject bullet;
    Rigidbody m_rigidBody;

    private void OnTriggerEnter(Collider other) {
        if (other.CompareTag("Enemy")) {
            foreach(GameObject gameObject in Manager.instance.poolMutantPrefab) {
                transform.LookAt(gameObject.transform);
            }         
            StartCoroutine (Shoot());
        }
    }
    IEnumerator Shoot() {
        //while (true) {
            yield return new WaitForSeconds(timeToShoot);
            Instantiate(bullet, transform.position, Quaternion.identity);
        //}
    }

}
