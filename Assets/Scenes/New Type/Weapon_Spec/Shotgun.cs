using UnityEngine;

public class Shotgun : RangedWeapon
{
    public Transform firePoint;
    public GameObject bulletPrefab;
    private bool isCharging;
    private float chargeTime;

    private void Update()
    {
        // if (Input.GetMouseButtonDown(0))
        // {
        //     isCharging = true;
        //     chargeTime = 0;
        // }

        // if (isCharging)
        // {
        //     chargeTime += Time.deltaTime;
        // }

        // if (Input.GetMouseButtonUp(0))
        // {
        //     isCharging = false;
        //     Attack();
        // }
    }

    public override void Attack()
    {
        // 可以根据chargeTime调整子弹速度或伤害等属性
        float bulletSpeed = Mathf.Clamp(chargeTime * 10, 10, 50);
        float bulletDamage = Damage * Mathf.Clamp(chargeTime, 1, 3);

        // 实例化子弹并设置属性
        GameObject bulletInstance = Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
        Bullet bullet = bulletInstance.GetComponent<Bullet>();
        bullet.Speed = bulletSpeed;
        bullet.Damage = bulletDamage;
    }
}
