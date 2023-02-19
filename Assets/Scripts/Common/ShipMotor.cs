using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipMotor
{
    private readonly IShipInput shipInput;
    private readonly IShipAttack shipAttack;

    private readonly Transform transformToMove;
    private readonly ShipSettingSO shipSetting;
    private readonly ShipWeaponSystem shipWeapon;

    public ShipMotor(IShipInput shipInput, IShipAttack shipAttack, Transform transformToMove, ShipSettingSO shipSetting, ShipWeaponSystem shipWeapon)
    {
        this.shipInput = shipInput;
        this.shipAttack = shipAttack;
        this.transformToMove = transformToMove;
        this.shipSetting = shipSetting;
        this.shipWeapon = shipWeapon;
    }

    public void Tick()
    {
        ShipRotation();
        ShipMovement();
        ShipAttack();
    }

    private void ShipAttack()
    {
        if(shipAttack.GetInput())
        {
            shipWeapon.CheckShoot();
        }
    }

    private void ShipMovement()
    {
        float moveSpeed = shipInput.Vetical * shipSetting.MoveSpeed * Time.deltaTime;
        transformToMove.position += transformToMove.forward * moveSpeed;
    }

    private void ShipRotation()
    {
        float timeTurn = shipInput.Rotation * shipSetting.TurnSpeed * Time.deltaTime;
        transformToMove.Rotate(Vector3.up * timeTurn);
    }
}
