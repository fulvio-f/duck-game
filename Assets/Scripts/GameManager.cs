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

        InvokeRepeating("Spawn_up",1f,2f);
        InvokeRepeating("Spawn_down",1f,2f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

   

    void Spawn_up()
    {
        float Randx = Random.Range(-6.69f,7.4f);
        float y = -0.49f;

        Vector3 randPosition = new Vector3(Randx,y,0);

        Instantiate(target_up, randPosition, Quaternion.identity);
    }

    void Spawn_down()
    {
        float Randx = Random.Range(-6.69f,7.4f);
        float y = -1.86f;

        Vector3 randPosition = new Vector3(Randx,y,0);

        Instantiate(target_down, randPosition, Quaternion.identity);
    }

    public void IncrementScore()
    {
        score++;
        print(score);
    }
}

