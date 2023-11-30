using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnotherClass
{
    public int apples;
    public int bananas;


    private int stapler;
    private int sellotape;


    public void FruitMachine(int a, int b)
    {
        int answer;
        answer = a + b;
        Debug.Log("Furit total:" + answer);
    }


    private void OfficeSort (int a, int b)
    {
        int answer;
        answer = a + b;
        Debug.Log("office Supplies total: " + answer);
    }
    
}
