using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    // Start is called before the first frame update

     public List <int[]> testCases = new List <int[]>();
    public List <int[]> testExpectedResults = new List <int[]>();
    public int[] resultado = new int[2] {0,0};

    void Start()
    {
        testCases.Add(new int[]{8,1,2,2,3});
        testExpectedResults.Add(new int[]{4,0,1,1,3});
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.K))
        {
            for (int i = 0; i < testCases.Count; i++)
            {
                int[] result = NumbersLessThan(testCases[i]);
                bool passedTest = CompareTestResult(result,testExpectedResults[i]);
                Debug.Log($"Test {i}  :  {passedTest}");   
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
