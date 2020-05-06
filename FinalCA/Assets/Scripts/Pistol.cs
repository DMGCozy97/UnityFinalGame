using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

class Pistol : RayCastWeapons
{
    public override void Fire(Vector3 fireFromePosition)
    {
        base.Fire(fireFromePosition);

        if (Physics.Raycast(fireFromePosition, transform.forward, out RaycastHit, Range))
        {
            HealthComponent hitHealth = RaycastHit.transform.GetComponent<HealthComponent>();
            if (hitHealth != null)
                ApplyDamage(hitHealth);
        }
    }
}

