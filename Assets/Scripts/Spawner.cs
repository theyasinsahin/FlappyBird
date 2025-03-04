using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{

    public Birdy BirdScript;

    public GameObject Borular;

    public float height;

    public float time1;

    private void Start()
    {
        StartCoroutine(SpawnObject(time1));
    }
    public IEnumerator SpawnObject(float time)
    {
        while (!BirdScript.isDead)
        {
            Instantiate(Borular, new Vector3(3, Random.Range(-height, height), 0), Quaternion.identity);

            yield return new WaitForSeconds(time);

        }
    }
}
