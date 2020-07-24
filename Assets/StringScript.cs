using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StringScript : MonoBehaviour
{
    // Start is called before the first frame update

    string firstName = "松本";
    int hp = 100;

    void Start()
    {
        Debug.Log(firstName + "のHP: " + hp);   
        Debug.Log(string.Format("{0}のHP: {1}", firstName, hp));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
