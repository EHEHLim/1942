using System.Collections;
using System.Collections.Generic;
using UnityEngine;

  
public class spawn : MonoBehaviour {
    public bool enableSpawn = false;
    public GameObject enemy; //Prefab�� ���� public ���� �Դϴ�.
    void SpawnEnemy()
    {
        float randomX = Random.Range(0.03f, 9.97f); //���� ��Ÿ�� X��ǥ�� �������� ������ �ݴϴ�.
        if (enableSpawn)
        {
         Instantiate(enemy, new Vector3(randomX, 12f, 0f), Quaternion.identity); //������ ��ġ��, ȭ�� ���� ������ Enemy�� �ϳ� �������ݴϴ�.
        }
    }
    void Start () {
        InvokeRepeating("SpawnEnemy", 1, 0.8f); //3���� ����, SpawnEnemy�Լ��� 1�ʸ��� �ݺ��ؼ� ���� ��ŵ�ϴ�.
    }

}


