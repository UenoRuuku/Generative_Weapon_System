using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float Speed { get; set; }
    public float Damage { get; set; }

    void Update()
    {
        transform.position += transform.forward * Speed * Time.deltaTime;
    }

    // 当子弹与其他对象发生碰撞时的处理逻辑
    private void OnCollisionEnter(Collision collision)
    {
        // 这里处理子弹与其他对象碰撞的逻辑，例如造成伤害或销毁子弹
    }
}
