using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GranadeWeapon : BaseWeapon
{
    [SerializeField] private GameObject granade;
    [SerializeField] private Transform throwPos;

    [SerializeField] private float throwForce;
    [SerializeField] private float throwUpwardForce;

    public override void Fire()
    {
        GameObject projectile = Instantiate(granade, throwPos.position, Camera.main.transform.rotation);

        Rigidbody projectileRb = projectile.GetComponent<Rigidbody>();

        Vector3 forceToAdd = Camera.main.transform.forward * throwForce + transform.up * throwUpwardForce;

        projectileRb.AddForce(forceToAdd, ForceMode.Impulse);
    }
}
