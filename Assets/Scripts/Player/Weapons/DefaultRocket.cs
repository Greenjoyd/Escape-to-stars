using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DefaultRocket : MonoBehaviour
{
    [SerializeField] float damage = 20f;
    [SerializeField] GameObject explosionPrefab;
     void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Enemy")
        {
            other.GetComponent<EnemyScript>().takeDamage(damage);
            Instantiate(explosionPrefab, transform.position, Quaternion.identity);
            Destroy(gameObject);
        }
        
    }

}
