using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FruitSpawner : MonoBehaviour
{
    [SerializeField] private GameObject[] fruits;

    private BoxCollider2D _collider;

    float x1, x2; // размер коллайдера с которого будут инстанциироваться наши фрукты и бомба


    private void Awake()
    {
        _collider = GetComponent<BoxCollider2D>();
        // запускаем размер коллайдера Spawn не в корутине, чтобы он отработал только один раз 
        // _collider.bound.size.x - это размер половины коллайдера
        x1 = transform.position.x - _collider.bounds.size.x / 2f;
        x2 = transform.position.x + _collider.bounds.size.x / 2f;

    }

    private void Start()
    {
        StartCoroutine(SpawnFruit(1f));

    }

    IEnumerator SpawnFruit(float time)
    {
        yield return new WaitForSeconds(time);

        Vector3 temp = transform.position;
        temp.x = Random.Range(x1, x2);

        Instantiate(fruits[Random.Range(0, fruits.Length)], temp, Quaternion.identity);

        StartCoroutine(SpawnFruit(Random.Range(1f, 2f)));

    }
     
} // class
 

























