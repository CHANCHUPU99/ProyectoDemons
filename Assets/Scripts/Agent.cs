using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Agent : MonoBehaviour {
    public NavMeshAgent navMeshAgent;
    public List<Transform> target;
    private int itPosition;
    void Start() {
        GameObject contentTarget = GameObject.Find("ContentTarget");
        target = new List<Transform>();
        for (int i = 0; i < contentTarget.transform.childCount; i++) {
            target.Add(contentTarget.transform.GetChild(i).transform);
        }
    
        itPosition = 0;
        ShuffleArray.shuffle(target);
    }


    void Update() {
        move();
    }

    private void move() {
        navMeshAgent.SetDestination(target[itPosition].position);
        if (Vector3.Distance(target[itPosition].position, this.transform.position) < 2) {
            itPosition++;
            if(itPosition >= target.Count - 1) {
                itPosition = 0;
                ShuffleArray.shuffle(target);
            }
        }
    }
}

public static class ShuffleArray {
    public static void shuffle<T>(this IList<T> ts) {
        var count = ts.Count;
        var last = count - 1;
        for (var i = 0; i < last; ++i) {
            var r = UnityEngine.Random.Range(i, count);
            var tmp = ts[i];
            ts[i] = ts[r];
            ts[r] = tmp;
        }
    }
}
