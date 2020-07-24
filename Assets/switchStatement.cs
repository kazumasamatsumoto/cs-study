using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class switchStatement : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        string characterType = "";

        // 特定できるものはswitch（固定値）
        switch (characterType)
        {
            case "player":
            case "friends":
                Debug.Log("プレイヤーだよ");
                break;
            case "enemy":
                Debug.Log("敵だよ");
                break;
            default:
                Debug.Log("その他");
                break;
        }

        // 比較するのものはif文がお勧め(演算子)
        // switch文をif文に書き換えよ
        if (characterType == "player" || characterType == "friends")
        {
            Debug.Log("プレイヤーだよ");
        }
        else if (characterType == "enemy")
        {
            Debug.Log("敵だよ");
        }
        else
        {
            Debug.Log("その他");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
