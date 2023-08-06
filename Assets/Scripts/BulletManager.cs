using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletManager : MonoBehaviour
{
    [SerializeField] private float speed;
    private float bulletLifeTime = 5;
    Rigidbody m_rigidBody;
    private Transform player;
    [SerializeField] float timeBetweenShoots;
   
    private void Start() {
        player = FindObjectOfType<Agent>().transform;
        m_rigidBody= GetComponent<Rigidbody>();
        launchProjectible();
    }

    private void launchProjectible() {
        Vector3 directionTolayer = (player.position - transform.position).normalized;
        m_rigidBody.velocity = directionTolayer * speed;
        StartCoroutine(destroyBullet());
    }
     IEnumerator destroyBullet() {
        yield return new WaitForSeconds(bulletLifeTime);
    }
}
