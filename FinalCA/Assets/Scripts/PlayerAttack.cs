using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class PlayerAttack : MonoBehaviour
{
    

    public Weapon[] weapons;
    int activeWeaponIndex = -1;
    public  Weapon activeWeapon;

    public int index = 2;
  
    private void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        SetActiveWeapon(0);
    }



    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
            SetActiveWeapon(0);
        if (Input.GetKeyDown(KeyCode.Alpha2))
            SetActiveWeapon(1);
        if (Input.GetKeyDown(KeyCode.Alpha3))
            SetActiveWeapon(2);
        if (activeWeapon == null) return;

        if (Input.GetButtonDown("Fire1"))
        {
            activeWeapon.Fire(transform.position);
        }

    }
   
    private void SetActiveWeapon(int index)
    {
       if(index != activeWeaponIndex)
        {
            if(index >= 0 && index <= weapons.Length)
            {
                if (activeWeapon)
                    Destroy(activeWeapon.gameObject);

                activeWeapon = Instantiate(weapons[index], transform);
                activeWeaponIndex = index;
            }
        }
    }

   

}

