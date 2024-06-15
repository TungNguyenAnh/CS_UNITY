using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Purchasing;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance {
        get => instance;
    }

    private static GameManager instance;
    private int coin;

    private void Awake() {
        if (instance != null) {
            DestroyImmediate(gameObject);
            return;
        }
        instance = this;
        DontDestroyOnLoad(gameObject);
    }
    public void AddCoin(int coin) {
        this.coin += coin;

    }
    public int GetCoin() {
        return coin;
    }
}
