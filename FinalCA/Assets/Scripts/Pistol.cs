using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

class Pistol : RayCastWeapons
{
    private AudioSource mAudioSrc;

    void Start()
    {
        mAudioSrc = GetComponent<AudioSource>();
    }

    public override void Fire(Vector3 fireFromePosition)
    {
        mAudioSrc.Play();

        base.Fire(fireFromePosition);

        if (Physics.Raycast(fireFromePosition, transform.forward, out RaycastHit, Range))
        {
            HealthComponent hitHealth = RaycastHit.transform.GetComponent<HealthComponent>();
            if (hitHealth != null)
                ApplyDamage(hitHealth);
        }
    }
}

