using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
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
                ControlType(typeAttacking, weakeness, resistence);
                break;
            case Damange_Type.PIERCING:
                ControlType(typeAttacking, weakeness, resistence);
                break;
            case Damange_Type.MAGICAL:
                ControlType(typeAttacking, weakeness, resistence);
                break;
            case Damange_Type.BLUDGEONING:
                ControlType(typeAttacking, weakeness, resistence);
                break;
            case Damange_Type.FORCE:
                ControlType(typeAttacking, weakeness, resistence);
                break;
            default:
                ControlType(typeAttacking, weakeness, resistence);
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

    void ControlType(Damange_Type attk ,Damange_Type weak,Damange_Type resistence)
    {
        if (attk == resistence)
        {
            baseDamange /= 2;
            Debug.Log("il nemico è resistente al tipo,i danni si dimezzano, danni fatti " + baseDamange);
        }
        else if (attk == weak)
        {
            baseDamange *= 2;
            Debug.Log("il nemico è debole al tipo, i danni si raddopiano, danni fatti " + baseDamange);

        }
        else
        {
            Debug.Log("il nemico non ha una resistenza o debolezza al tipo di attacco, danni fatti " + baseDamange);
        }
    }
}
