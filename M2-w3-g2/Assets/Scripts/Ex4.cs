using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ex4 : MonoBehaviour
{
    [SerializeField] int[] array;
    [SerializeField] int valore;
    [SerializeField] int times;

    void Start()
    {
        //int indice = Find(array, valore);
        //Debug.Log("questo è dove si trova il valore " + indice);
        //Debug.Log("array originale");
        //PrintArr(array);
        //Debug.Log("array modificato");
        //PutInBack(indice, array);
        //Debug.Log("sposto tutto di uno");
        //ShiftOne(array);
        Debug.Log("sposto tot volte " + times);
        ShiftTimes2(array, times);




    }
    void PrintArr(int[] arr)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            Debug.Log(arr[i]);
        }
    }

    int Find(int[] arr, int value)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] == value)
            {
                return i;
            }

        }
        Debug.Log("non è stato trovato il valore verrà restituito 0, come indice");
        return 0;
    }

    void PutInBack(int index, int[] arr)
    {
        int[] secondArr = new int[array.Length];
        for (int i = 0; i < arr.Length; i++)
        {
            //il codice qua sotto ha la stessa logica di quello sotto ma per come è stato detto alla macchian esso non funziona
            //if (i >= index)
            //{
            //    secondArr[i]=arr[i+1];
            //    Debug.Log("ha messo");
            //}else if(i== arr.Length)
            //{
            //    secondArr[i] = arr[index];
            //    Debug.Log("valore i " + i + " valore arr " + (arr.Length - 1));
            //}
            //else
            //{
            //    secondArr[i] = arr[i];
            //    Debug.Log("mette i valori");
            //}


            if (i == array.Length - 1)
            {
                secondArr[i] = arr[index];
            }
            else if (i < index)
            {
                secondArr[i] = arr[i];
            }
            else
            {
                secondArr[i] = arr[i + 1];
                //Debug.Log("avvine " + i);
            }
            // Debug.Log("2 valore i " + i + " valore arr " + (arr.Length - 1));
        }
        PrintArr(secondArr);
    }

    void ShiftOne(int[] arr)
    {
        int[] secondArr = new int[arr.Length];
        for (int i = 0; i < arr.Length; i++)
        {
            if (i == 0)
            {
                secondArr[i] = arr[arr.Length - 1];
            }
            else
            {
                secondArr[i] = arr[i - 1];
                //    Debug.Log("ciclo " + i);
                //    Debug.Log("valore al momento dello scambio "+arr[i-1]);
            }
        }
        PrintArr(secondArr);

    }

    void ShiftTimes1(int[] arr,int times)
    {
        int[] secondArr = new int[arr.Length];
        for (int i = 0; i <=times; i++)
        {
            secondArr = new int[arr.Length];
            for (int j = 0; j < arr.Length; j++)
            { 
                if (j== 0)
                {
                    secondArr[j] = arr[arr.Length - 1];                 
                }
                else
                {
                    secondArr[j] = arr[j- 1];
                }

            }
            arr = secondArr;
            //Debug.Log("ciclo"+i);
            //Debug.Log("arr come sta in questo ciclo");
            //PrintArr(arr);

        }
        PrintArr(secondArr);

    }

    void ShiftTimes2 ( int[] arr,int times)
    {
        int[] secondArr=new int[arr.Length];
        int j = 0;
        for (int i = 0;i < arr.Length; i++)
        {
            if(i+times < arr.Length)
            {
                secondArr[i] = arr[i + times];
            }
            else
            {
                secondArr[i] = arr[j];
                j++;
            }
        }
        PrintArr(secondArr);

    }
}
