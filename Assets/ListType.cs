using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ListType : MonoBehaviour
{
    // List
    // 宣言、代入、取得、長さ取得、追加、削除
    // for文との兼ね合い
    // foreach
    // Start is called before the first frame update
    void Start()
    {
        List<int> numbers = new List<int>() { 1, 2, 3 };
        Debug.Log(numbers[0]);
        Debug.Log(numbers[1]);
        Debug.Log(numbers[2]);

        // 代入
        numbers[1] = 22;
        Debug.Log(numbers[1]);

        numbers.Add(100);
        Debug.Log(numbers[3]);
        // 長さの取得
        Debug.Log(numbers.Count);

        // 削除
        numbers.RemoveAt(3);// リストの順番
        numbers.Remove(3);// 値に合致するものを削除
        Debug.Log(numbers.Count);

        // for文
        for (int i = 0; i < numbers.Count; i++)
        {
            Debug.Log(numbers[i]);
        }

        List<int> numberList = new List<int>();
        for(int i = 0; i < 10; i++)
        {
            numberList.Add(i);
        }
        for (int i = 0; i < numberList.Count; i++)
        {
            Debug.Log(numberList[i]);
        }

        // foreach
        List<string> nameList = new List<string>() { "松本", "岡田", "山本" };
        foreach (string firstName in nameList)
        {
            Debug.Log(firstName);
        }

        // 演習 0-99までの3の倍数を要素に持つListの作成と確認
        List<int> threeByList = new List<int>();
        for (int i = 0; i < 100; i++)
        {
            if (i == 0)
            {
                continue;
            }
            if (i % 3 == 0)
            {
                threeByList.Add(i);
            }
        }

        foreach(int threeBy in threeByList)
        {
            Debug.Log(threeBy);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
