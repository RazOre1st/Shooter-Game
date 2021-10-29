using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
public GameObject Enemy;
{	
    // Start is called before the first frame update
    void Start()
    {
		StartCoroutine(StartSpawning());
	}
		IEnumerator Start Spawning()
		{
			yield return new WaitForSeonds(Random.Range(7f, 10f);
				StartCoroutine(StartSpawning());
		}
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
