using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    // Start is called before the first frame update

    public int[] resultado = new int[2] {0,0};
    public int[] input;
     int target;



    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.K))
        {
            int[] test1 = SumaDos(input, target);
            foreach (int n in test1)
            {
                Debug.Log(n);    
            }
        }
    }

    public  int[] SumaDos(int[] numbers, int target)
    {
        for (int i = 0; i < numbers.Length; i++)
        {
            for (int j = 0; j < numbers.Length; j++)
            {
                if(i != j)
                {
                    if(numbers[i] + numbers[j] == target)
                    {
                        resultado[0] = i;
                        resultado[1] = j;
                    }
                }
            }
        }
        return resultado;
    }


}
