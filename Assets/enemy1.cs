using System.Collections;
using System.Collections.Generic;
using UnityEngine;


    public class enemy1 : MonoBehaviour
    {
        public int health = 1;


        void OnTriggerEnter2D(Collider2D other)
{
    if (other.gameObject.tag == "Bullet")
    {
        Destroy(gameObject); // �Ѿ� ������Ʈ �ı�
        Destroy(other.gameObject); // �� ������Ʈ �ı�
    }
}


  
    }

