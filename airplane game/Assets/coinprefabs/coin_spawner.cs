using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coin_spawner : MonoBehaviour
{
    public GameObject coinprefabs;
    // Start is called before the first frame update
    void Start()
    {
           StartCoroutine(CoinSpawner());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void coinspawn()
    {

         float rand=Random.Range(-5.47f,5.47f);
    Instantiate(coinprefabs,new Vector3(rand,transform.position.y,transform.position.z),Quaternion.identity);
    }
     IEnumerator
      CoinSpawner()
     

     {
          while(true){
    yield return new WaitForSeconds(5);
    coinspawn();

     }
     }
}
