using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ex2 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int a = Random.Range(0, 30);
        int b = Random.Range(0, 30);
        Debug.Log("A = " + a + " B= " + b);
        Swap(a, b);
        //usando il debug.log, fuori dalla funzione non ci farà lo scambio, perchè la funzione lavora sulla copia delle variabili, quindi il modificare di una copia
        //Funziona solo esclusivamente su essa, non intacando l'originale.
        Debug.Log("A swap= " + a + " B swap=" + b);
        Swap(ref a, ref b);
        //invece usando il ref (reference) non fa una copia, ma va a lavorare direttamente sull'originale, cosi avviene lo scambio in questo caso.
        Debug.Log("A swapref= " + a + " B swapref=" + b);




    }
    void Swap(int n, int m){
        int c;
        c = n;
        n = m;
        m = c;
        //usando il Debug.log qui, dentro la funzione essa ci darà il valore scambiato, come lo vogliamo.
        //Essendo che essa sta restituendo il valore cambiato della copia.
        //Debug.Log("A= " + n + " B=" + m);
    }
    void Swap(ref int n, ref int m)
    {
        int c;
        c = n;
        n = m;
        m = c;
        //usando il debug.log qui o fuori, in questo esercizio non cambia il risulato, perchè lo scambio avviene direttamente sull'originale
        //Debug.Log("A= " + n + " B=" + m);
    }

   
}
