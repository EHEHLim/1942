using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet : MonoBehaviour
{
    public GameObject bulletPrefab; // 발사할 총알 프리팹
    public float bulletSpeed = 5f; // 총알 속도

    void Update()
    {
        if (Input.GetButtonDown("Fire2")) // 마우스 왼쪽 버튼을 누르면
        {
            GameObject bullet = Instantiate(bulletPrefab, transform.position, Quaternion.identity); // 총알 생성
            bullet.GetComponent<Rigidbody2D>().velocity = transform.up * bulletSpeed; // 총알에 속도 부여
        }
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Enemy") // 충돌한 오브젝트가 적이면
        {
            Destroy(gameObject); // 총알 파괴
        }
    }
}

