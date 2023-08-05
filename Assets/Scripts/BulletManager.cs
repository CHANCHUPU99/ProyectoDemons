using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletManager : MonoBehaviour
{
    [SerializeField] private float speed;
    Rigidbody m_rigidBody;
    private Transform player;
    [SerializeField] float timeBetweenShoots;
   
    private void Start() {
        player = FindObjectOfType<Agent>().transform;
        m_rigidBody= GetComponent<Rigidbody>();
        LaunchProjectible();
    }

    private void LaunchProjectible() {
        Vector3 directionTolayer = (player.position - transform.position).normalized;
        m_rigidBody.velocity = directionTolayer * speed;
        //StartCoroutine(DestroyProjectible());
    }

}
