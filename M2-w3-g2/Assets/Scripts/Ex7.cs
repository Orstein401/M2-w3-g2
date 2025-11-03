using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ex7 : MonoBehaviour
{
    [SerializeField] State stato;
    [SerializeField] Damange_Type typeAttacking, resistence, weakeness;
    [SerializeField] int baseDamange;
    void Start()
    {
        switch (typeAttacking)
        {
            case Damange_Type.SLASHING:
                baseDamange /= 2;
                Debug.Log("il nemico è resistente al tipo,i danni si dimezzano, danni fatti " + baseDamange);
                break;
        }
        
    }

   
    void Update()
    {
        switch (stato)
        {
            case State.IDLE:
                Debug.Log("enemy sta fermo");
                break;
            case State.AGGROED:
                Debug.Log("il nemico sta inseguedo il gioccatore");
                break;
            case State.ATTACKING:
                Debug.Log("il nemico sta attacando il gioccatore");
                break;
            case State.DEFEATED:
                Debug.Log("il nemico è stato sconfitto");
                break;
        }
    }
}
