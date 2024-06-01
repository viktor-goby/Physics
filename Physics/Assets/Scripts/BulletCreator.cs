using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletCreator : MonoBehaviour
{

    [SerializeField] private GameObject _bulletPrefab;
    [SerializeField] private int _bulletVelocity;

    private void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            GameObject newBullet = Instantiate(_bulletPrefab, transform.position, transform.rotation);
            newBullet.GetComponent<Rigidbody>().velocity = transform.forward * _bulletVelocity;
        }
    }

}
