using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletManager : MonoBehaviour
{
    Rigidbody m_rigidBody;

    private void Start() {
        m_rigidBody = gameObject.GetComponent<Rigidbody>();
    }

    private void OnTriggerEnter(Collider other) {
        if (other.CompareTag("Enemy")) {
            foreach(GameObject enemy in Manager.instance.poolMutantPrefab) {
                Destroy(enemy);
            }
        }
    }
}
