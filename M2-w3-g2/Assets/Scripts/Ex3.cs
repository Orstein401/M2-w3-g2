using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ex3 : MonoBehaviour
{
    [SerializeField] int dividendo;
    [SerializeField] int divisore;

    bool SafeDivide(int dividendo, int divisore, out int risultato)
    {
        if (divisore == 0)
        {
            risultato = 0;
            return false;
        }
        else
        {
            risultato = dividendo / divisore;
            return true;
        }
       
    }

    void Start()
    {
        int risultato;
        bool verifica = SafeDivide(dividendo, divisore, out risultato);
        if (verifica == false)
        {
            Debug.LogWarning("il divisore non può essere zero");
        }
        else
        {
            Debug.Log("la divisione può essere fatta, il risultato è " + risultato);
        }
    }


}
