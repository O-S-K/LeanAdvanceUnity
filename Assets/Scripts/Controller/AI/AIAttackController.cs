using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIAttackController : IShipAttack
{
    private float timeAttack = 3;
    private float currentTimeAttack;

    public bool GetInput()
    {
        if (currentTimeAttack < timeAttack)
        {
            currentTimeAttack += Time.deltaTime;
            return false;
        }
        else
        {
            currentTimeAttack = 0;
            return true;
        }
    }
}
