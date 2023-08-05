using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Manager : MonoBehaviour {
    public GameObject player;
    int itPlayer;
    float timer = 0;
    public Transform poolContent;
    public List<GameObject> poolMutantPrefab;
    public static Manager instance;

    private void Awake() {
        instance = this;
        poolMutantPrefab = new List<GameObject>();
        for (int i = 0; i < poolContent.childCount; i++) {
            GameObject temp = poolContent.GetChild(i).gameObject;
            temp.SetActive(false);
            poolMutantPrefab.Add(temp);
        }
    }
    //private void Start() {
    //    poolMutantPrefab = new List<GameObject>();
    //    for (int i = 0; i < poolContent.childCount; i++) {
    //        GameObject temp = poolContent.GetChild(i).gameObject;
    //        temp.SetActive(false);
    //        poolMutantPrefab.Add(temp);
    //    }
    //}

    void Update() {
        //if (Input.GetKeyDown(KeyCode.Space)) {
        activePrefab();
        //itPlayer++;
        //GameObject clone = Instantiate(player);
        //clone.name = "Player" + itPlayer;
        //}
    }

    private void activePrefab() {
        timer += Time.deltaTime;
        Debug.Log(timer);
        if (timer >= 2) {
            //getPrefab();itPlayer++;
            GameObject clone = Instantiate(player);
            clone.name = "Player" + itPlayer;
            timer = 0;
        }
    }

    public GameObject getPrefab() {
        int count = 0;        
        foreach (GameObject temp in poolMutantPrefab) {
                count ++;
            if (!temp.activeSelf) {   
                    temp.SetActive(true);
                temp.GetComponent<Animator>().SetBool("Iswalking",true);
                    return temp;
                }
            if(count >= poolMutantPrefab.Count) {
                Debug.LogError("hasta aqui llego");
            }
        }
         return null;
    }
}
