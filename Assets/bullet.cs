using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bullet : MonoBehaviour
{
    public GameObject bulletPrefab; // �߻��� �Ѿ� ������
    public float bulletSpeed = 5f; // �Ѿ� �ӵ�

    void Update()
    {
        if (Input.GetButtonDown("Fire2")) // ���콺 ���� ��ư�� ������
        {
            GameObject bullet = Instantiate(bulletPrefab, transform.position, Quaternion.identity); // �Ѿ� ����
            bullet.GetComponent<Rigidbody2D>().velocity = transform.up * bulletSpeed; // �Ѿ˿� �ӵ� �ο�
        }
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Enemy") // �浹�� ������Ʈ�� ���̸�
        {
            Destroy(gameObject); // �Ѿ� �ı�
        }
    }
}

