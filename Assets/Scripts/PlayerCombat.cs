using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCombat : MonoBehaviour
{
    [SerializeField] BaseWeapon meleeWeapon;
    [SerializeField] BaseWeapon hitScanWeapon;
    [SerializeField] BaseWeapon granadeWeapon;

    private BaseWeapon currentWeapon;

    private void Start()
    {
        currentWeapon = hitScanWeapon;
    }

    private void OnAttack()
    {
        currentWeapon.Fire();
    }

    private void Update()
    {
        if (Input.GetKeyUp(KeyCode.Alpha1)) currentWeapon = meleeWeapon;
        if (Input.GetKeyUp(KeyCode.Alpha2)) currentWeapon = hitScanWeapon;
        if (Input.GetKeyUp(KeyCode.Alpha3)) currentWeapon = granadeWeapon;

        if (Input.GetMouseButtonDown(0)) OnAttack();
    }
}
