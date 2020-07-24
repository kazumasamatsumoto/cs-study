using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstScript : MonoBehaviour
{
    // 変数と定数
    // 変数：値を変えられるもの
    // 変数の型 変数名
    // Start is called before the first frame update

    // 変数の型
    // 文字列型
    string text = "こんにちは";
    // 整数
    int hp = 123;
    // 浮動小数点数
    float speed = 198.12f;
    // 論理値
    bool flag1 = true;
    bool flag2 = false;

    // 演算 +, -, *, +=, /, %, ++, --, &&, ||, !,
    void Start()
    {
        string say; // 宣言
        say = "こんにちは、世界"; // 代入
        string hello = "Hello World"; // 宣言と代入を同時にできる
        Debug.Log(hello);
        Debug.Log(say);

        const string sayConst = "hello world2"; ;
        Debug.Log(sayConst);

        Debug.Log(text);
        Debug.Log(hp);
        Debug.Log(speed);
        Debug.Log(flag1);
        Debug.Log(flag2);

        // 四則演算
        int a = 10;
        int b = 12;
        Debug.Log(a + b);
        Debug.Log(a - b);
        Debug.Log(a * b);
        Debug.Log(a / b);

        // 浮動小数点数
        float c = 10.0f;
        float d = 2.0f;
        Debug.Log(d / c);

        // あまり
        int e = 10;
        int f = 3;
        Debug.Log(e % f);
        Debug.Log(e % 2); // 偶数なら
        Debug.Log(f % 2); // 奇数なら　分岐条件などで使われる

        // インクリメント演算子
        int g = 10;
        g = g + 1;
        g += 1;
        g++; // インクリメント演算子
        Debug.Log(g); // 13になる

        // デクリメント演算子
        int h = 10;
        h = h - 1;
        h -= 1;
        h--;
        Debug.Log(h); // 7になる

        // 真偽値
        bool flag3 = true;
        bool flag4 = false;
        Debug.Log(flag3 && flag4); // &&: and条件 どちらもtrue
        Debug.Log(flag3 || flag4); // ||: or条件 どちらかtrue
        Debug.Log(!flag3); // !: 否定式


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
