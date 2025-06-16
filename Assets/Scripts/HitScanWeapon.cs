using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitScanWeapon : BaseWeapon
{
    [SerializeField] private float damage;

    [SerializeField] private Transform firePoint;
    [SerializeField] private ParticleSystem hitEffect;

    public override void Fire()
    {
        Shoot();
    }

    private void Shoot()
    {
        Vector3 targetDirection = Camera.main.transform.forward;

        bool hit = Physics.Raycast(firePoint.position, targetDirection, out RaycastHit hitObject);
        if (!hit) return;

        Instantiate(hitEffect, hitObject.point, Quaternion.identity);

        bool foundDamageable = hitObject.collider.gameObject.TryGetComponent(out Damageable damageHit);
        if (!foundDamageable) return;

        damageHit.TakeDamage(damage);
    }
}
