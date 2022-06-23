using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    public GameObject target_up;
    public GameObject target_down;
    public TMP_Text scoreText;

    int score = 0;
    
    float Countdown = 20f;

    // Start is called before the first frame update
    void Start()
    {

        InvokeRepeating("Spawn",1f,0.5f);   
    }

    // Update is called once per frame
    void Update()
    {
        Countdown -= Time.deltaTime;

        if(Countdown <= 0)
        {
            CancelInvoke("Spawn");
        }
        
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


    void Spawn()
    {
        int top_or_bot = Random.Range(0,2);

        if(top_or_bot == 0)
        {
            Spawn_down();
        }
        if(top_or_bot == 1)
        {
            Spawn_up();
        }
    }

    public void IncrementScore()
    {
        score++;
        print(score);

        scoreText.text = score.ToString();
    }
}

