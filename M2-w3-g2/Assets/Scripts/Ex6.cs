using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum Damange_Type
{
    SLASHING,
    PIERCING,
    MAGICAL,
    FORCE,
    BLUDGEONING
}
public class Ex6 : MonoBehaviour
{
    [SerializeField] Damange_Type typeAttacking, resistence, weakeness;
    [SerializeField] int baseDamange;
    void Start()
    {
        if (typeAttacking == resistence)
        {
            baseDamange /= 2;
            Debug.Log("il nemico è resistente al tipo,i danni si dimezzano, danni fatti " + baseDamange);
        }
        else if (typeAttacking == weakeness)
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
