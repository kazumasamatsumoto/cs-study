using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ifStatement : MonoBehaviour
{
    // if文
    // 演算子 >, >= , <, <=, ==, !=
    // Start is called before the first frame update
    void Start()
    {
        int hp = 100;
        if (hp > 150)
        {
            Debug.Log("処理A");
        }
        else if (hp > 80)
        {
            Debug.Log("処理B");
        }
        else
        {
            Debug.Log("その他");
        }

        // %は割ったあまり
        if (hp % 2 == 0)
        {
            Debug.Log("HPは偶数");
        }
        else
        {
            Debug.Log("HPは奇数");
        }
        // 演習：
        // hpを3で割った時のあまりが1の時 A
        // hpを3で割った時のあまりが2の時 B
        // hpを3で割った時のあまりが0の時 C

        if (hp%3 == 1)
        {
            Debug.Log("A");
        }
        else if (hp%3 == 2)
        {
            Debug.Log("B");
        }
        else
        {
            Debug.Log("C");
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
