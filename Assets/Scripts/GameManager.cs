using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject target_up;
    public GameObject target_down;
    // Start is called before the first frame update
    void Start()
    {
        Spawn_up();
        Spawn_down();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void Spawn_up()
    {
        float Randx = Random.Range(-6.69f,7.4f);
        float y = -0.49f;

        Vector3 randPosition = new Vector3(Randx,y,1);

        Instantiate(target_up, randPosition, Quaternion.identity);
    }

    void Spawn_down()
    {
        float Randx = Random.Range(-6.69f,7.4f);
        float y = -1.86f;

        Vector3 randPosition = new Vector3(Randx,y,4);

        Instantiate(target_up, randPosition, Quaternion.identity);
    }
}

