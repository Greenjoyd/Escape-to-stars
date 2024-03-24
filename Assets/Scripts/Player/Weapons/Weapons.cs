using UnityEngine;

public class WeaponShooter : MonoBehaviour
{
    public GameObject bulletPrefab;
    public AudioSource shootSound;
    [SerializeField] float force = 1000;


    private float lastShootTime = 0f; // Время последнего выстрела

    void Update()
    {
        if (Time.time - lastShootTime >= 0.5f)
        {
            Shoot();
        }
    }

    void Shoot()
    {
        GameObject bullet = Instantiate(bulletPrefab, transform.position, transform.rotation);

        bullet.transform.rotation = Quaternion.Euler(90f, 0f, 0f);

        bullet.GetComponent<Rigidbody>().AddForce(transform.forward * force);


        lastShootTime = Time.time;
    }
 
}
