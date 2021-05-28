using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    //要素5個の配列を用意し初期化をおこなう
    private void Start()
    {
        int[] array = { 1, 2, 3, 4, 5 };

        //for文を使い、配列の各要素の値を順番に表示
        for (int i = 0; i < array.Length; i++)
        {
            //配列の要素を表示する
            Debug.Log(array[i]);
        }

        //for文を使い、配列の各要素の値を逆順に表示
        for(int i = array.Length -1;0 <= i; i--)
        {
            //配列の要素を表示する
            Debug.Log(array[i]);

        }
    }

    //Update is called once per frame
    void Update()
    {

    }


}
