using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject target_up;
    public GameObject target_down;
    int score = 0;

    // Start is called before the first frame update
    void Start()
    {
	InvokeRepeating("SpawnUp",2f,2f);
	InvokeRepeating("SpawnDown",2f,2f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SpawnUp()
    {
	float randomX = Random.Range(-7f,7.6f);
	float fixedY = -0.09f;

	Vector3 randomPosition = new Vector3(randomX, fixedY, 0);

	Instantiate(target_up,randomPosition,Quaternion.identity);
    }

    void SpawnDown()
    {
	float randomX = Random.Range(-7f,7.6f);
        float fixedY = -1.22f;

        Vector3 randomPosition = new Vector3(randomX, fixedY, 0);

        Instantiate(target_down,randomPosition,Quaternion.identity);
    }

    public void IncrementScore()
    {
	score++;
	print(score);
    }
}
