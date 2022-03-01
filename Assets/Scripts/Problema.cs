using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Problema : MonoBehaviour
{
    // Start is called before the first frame update
    public List <int[]> testCases = new List <int[]>();
    public List <int[]> testExpectedResults = new List <int[]>();

    void Start()
    {
        testCases.Add(new int[]{8,1,2,2,3});
        testExpectedResults.Add(new int[]{4,0,1,1,3});
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.L))
        {
            for (int i = 0; i < testCases.Count; i++)
            {
                int[] result = NumbersLessThan(testCases[i]);
                bool passedTest = CompareTestResult(result,testExpectedResults[i]);
                Debug.Log($"Test {i}  :  {passedTest}");   
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

    private bool CompareTestResult(int[] result, int[] expectedResult)
    {
        if(expectedResult.Length != result.Length) return false;
        for (int i = 0; i < result.Length; i++)
        {
            if(result[i] != expectedResult[i]) return false;
        }
        return true;
    }
}
