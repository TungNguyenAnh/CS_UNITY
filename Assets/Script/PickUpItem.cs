using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUpItem : MonoBehaviour
{
    public int addCoin = 1;
    private void OnTriggerEnter2D(Collider2D collision) {

        //if (collision.tag == "Cherry") {
            GameManager.Instance.AddCoin(addCoin);
            Destroy(collision.gameObject);

        }
    }
//}