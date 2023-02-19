using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAttackController : IShipAttack
{
    public bool GetInput()
    {
        return Input.GetMouseButton(0);
    }
}
