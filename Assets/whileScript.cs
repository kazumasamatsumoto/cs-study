using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class whileScript : MonoBehaviour
{
    // 繰り返し
    // while
    // for
    // Start is called before the first frame update
    void Start()
    {

        // while文
        int x = 0;
        while (x < 10)
        {
            Debug.Log(x);
            x++;
        }

        // for文
        // 0-9
        // continue: 次の処理を行う（一つ飛ばす）
        // break: 処理を抜ける
        for (int i=100; i < 110; i++)
        {
            if (i == 107)
            {
                continue;
            }
            Debug.Log(i);
        }

        // 0-20までの偶数をconsoleに表示する
        for (int k=0; k <= 20; k++)
        {
            if (k % 2 == 1)
            {
                continue;
            }
            Debug.Log(k);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
