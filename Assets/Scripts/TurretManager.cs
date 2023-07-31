using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurretManager : MonoBehaviour
{
    float timeToShoot = 4;
    float timer;

    void Update()
    {
        shoot();
    }
    
    void shoot() {
        timer += Time.deltaTime;
        if (timer >= timeToShoot) {
            timer = 0;
            foreach (GameObject gameObject in Manager.instance.poolMutantPrefab) {
                gameObject.SetActive(false);  
                Debug.LogWarning("se desactivo");
            }
        }
        
    }
}
