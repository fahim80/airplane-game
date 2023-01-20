using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class alien_spawner : MonoBehaviour
{
    public GameObject[] alien;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Spawnalien());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void aliens()
    {
    int rand = Random.Range(0,alien.Length);
    float randXPos=Random.Range(-5.47f,5.47f);
    Instantiate(alien[rand],new Vector3(randXPos,transform.position.y,transform.position.z),Quaternion.Euler(0,0,0));
    }
    IEnumerator Spawnalien()
    {
        while(true){
    yield return new WaitForSeconds(4);
    aliens();
        }
    }
    }

