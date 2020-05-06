using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RayCastWeapons : Weapon
{
    protected RaycastHit RaycastHit;
    public float Range;
    public float DamagePerHit;

    protected void ApplyDamage(HealthComponent healthComponent)
    {
        healthComponent.ApplyDamage(DamagePerHit);
    }
}
