using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Pathfinding;

public class EnemyGFX : MonoBehaviour
{
    public AIPath aiPath;
    // Update is called once per frame
    void Update() {
        //thay đổi hướng của ENEMY theo tốc độ

        if (aiPath.desiredVelocity.x >= 0.01f) {
            transform.localScale = new Vector3(-1f, 1f, 1f);

        } else if (aiPath.desiredVelocity.x < 0.01f) {
            transform.localScale = new Vector3(1f, 1f, 1f);
        }
    }
}
