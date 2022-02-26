using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Problema : MonoBehaviour
{
    // Start is called before the first frame update
    public int[] input;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.L))
        {
            int[] test1 = NumbersLessThan(input);
            foreach (int n in test1)
            {
                Debug.Log(n);    
            }
        }
        
    }

    private int[] NumbersLessThan(int[] numbers)
    {
        int[] result = new int[numbers.Length];
        int cont = 0;

        for(int i = 0; i < numbers.Length; i++)
        {
            for(int j = 1; j < numbers.Length; j++)
            {
                if(numbers[i] > numbers[j])
                {
                    cont ++;
                }
            }
            result[i] = cont;
            cont = 0;
        }


        return result;
    }
}
