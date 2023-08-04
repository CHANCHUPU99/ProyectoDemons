using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurretManager : MonoBehaviour
{
    float timeToShoot = 2;
    float timer;
    [SerializeField] float force = 5f;
    [SerializeField] GameObject enemy;
    [SerializeField] GameObject bullet;
    Rigidbody m_rigidBody;
    private void Start() {
        m_rigidBody = bullet.GetComponent<Rigidbody>();
    }
    void Update()
    {
        //shoot();
    }


    private void OnTriggerEnter(Collider other) {
        if (other.CompareTag("Enemy")) {
                transform.LookAt(enemy.transform.position);
                shoot();
                Debug.LogWarning("se desactivo");
        }
    }
    void shoot() {
        //timer += Time.deltaTime;
        //if (timer >= timeToShoot) {
            //timer = 0;
            //foreach (GameObject gameObject in Manager.instance.poolMutantPrefab) {
                Instantiate(bullet);
                //m_rigidBody.AddForce(gameObject.transform.position( * force));
                //Destroy(gameObject);
                //gameObject.SetActive(false);  
                Debug.LogWarning("se desactivo");
            //}
        }
        
    
}
