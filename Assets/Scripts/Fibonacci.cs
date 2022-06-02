using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System;

public class Fibonacci : MonoBehaviour
{
    public TMP_InputField userInput;
    public TextMeshProUGUI display;
    long maxNumber=0;
 
    public void GenerateFibonacciNumbers()
    {
        display.text="";
        maxNumber = long.Parse(userInput.text);

        GetFibonacci(maxNumber,display);
    }

    private void GetFibonacci(long number,TextMeshProUGUI display)
    {
      long number1 = 0;
      long number2 = 1;
      long nextNumber = 0;

      for (int i = 1; i < number; i++)
      {
          if (i==1)
          {
            display.text += number1+ ",";
          }
          else if(i==2)
          {
            display.text += number2+ ",";
          }
          else
          {
            nextNumber=number1+number2;
            number1=number2;
            number2=nextNumber;

            display.text+=nextNumber+",";
          }
      }
    }
}
