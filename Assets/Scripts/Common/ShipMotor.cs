using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipMotor
{ 
    private readonly IMoveAble moveAble;
    private readonly IShipInput shipInput;
    private readonly IShipAttack shipAttack;

    private readonly Transform transformToMove;
    private readonly ShipSettingSO shipSetting;
    private readonly ShipWeaponSystem shipWeapon;

    public ShipMotor(IShipInput shipInput, IShipAttack shipAttack, IMoveAble moveAble, Transform transformToMove, ShipSettingSO shipSetting, ShipWeaponSystem shipWeapon)
    {
        this.shipInput = shipInput;
        this.shipAttack = shipAttack;
        this.moveAble = moveAble;
        this.transformToMove = transformToMove;
        this.shipSetting = shipSetting;
        this.shipWeapon = shipWeapon;
    }


    public void Tick()
    {
        Rotation();
        Move();
        Attack();
    }

    private void Attack()
    {
        if(shipAttack.GetInput())
        {
            shipWeapon.CheckShoot();
        }
    }


    public void Move()
    {
        moveAble.Move(new Vector3(shipInput.Horizontal, 0, shipInput.Vetical));
    }
    private void Rotation()
    {
        float timeTurn = shipInput.Horizontal * shipSetting.TurnSpeed * Time.deltaTime;
        transformToMove.Rotate(Vector3.up * timeTurn);
    }

}
