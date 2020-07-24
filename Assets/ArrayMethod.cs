using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrayMethod : MonoBehaviour
{
    // 配列
    // 宣言
    // 代入
    // 取得
    // for文との兼ね合い
    // Start is called before the first frame update
    void Start()
    {
        //int x1 = 0;
        //int x2 = 2;
        //int x3 = -3;
        // こういうのをまとめるときに使うのが配列
        int[] xList = new int[3]; // 宣言
        xList[0] = 0;
        xList[1] = 2;
        xList[2] = -3;

        int[] yList = new int[3] {11, 22, -33}; // 宣言 パターン2宣言の仕方

        // 取得
        Debug.Log(xList[0]);
        Debug.Log(xList[1]);
        Debug.Log(xList[2]);
        Debug.Log(yList[0]);
        Debug.Log(yList[1]);
        Debug.Log(yList[2]);

        // 長さの取得
        Debug.Log(xList.Length);

        // for文との連携
        for (int i = 0; i < xList.Length; i++)
        {
            Debug.Log(xList[i]);
        }

        // 0-30までの数を要素とする配列
        int[] numList = new int[31];
        for (int i = 0; i < 31; i++)
        {
            numList[i] = i;
        }

        for (int i = 0; i < numList.Length; i++)
        {
            Debug.Log(numList[i]);
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
