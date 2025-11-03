using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum State
{
    IDLE,
    AGGROED,
    ATTACKING,
    DEFEATED
}
public class Ex5 : MonoBehaviour
{
    [SerializeField] State stato;
    
    void Update()
    {
        if (stato == State.IDLE)
        {
            Debug.Log("enemy sta fermo");
        }else if (stato == State.AGGROED)
        {
            Debug.Log("il nemico sta inseguedo il gioccatore");
        }
        else if (stato == State.ATTACKING)
        {
            Debug.Log("il nemico sta attacando il gioccatore");
        }
        else if (stato == State.DEFEATED)
        {
            Debug.Log("il nemico è stato sconfitto");
        }
    }

    
}
