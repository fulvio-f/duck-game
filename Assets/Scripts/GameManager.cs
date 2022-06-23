using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    public GameObject target_up;
    public GameObject target_down;
    public GameObject EndMenu;
    public TMP_Text scoreText;

    int score = 0;
    float Countdown = 22f;    

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("Spawn",1f,0.5f);
    }  

    // Update is called once per frame
    void Update()
    {
	print(SceneManager.GetActiveScene().name);
	if (Countdown > -3)
	{
            Countdown -= Time.deltaTime;
	}
        if (Countdown <= 0)
        {
            CancelInvoke("Spawn");
	}
	if (Countdown < -2 && score > 0)
	{
	    scoreText.color = new Color32(255,247,5,255);
	    EndMenu.SetActive(true);
	}
    }

    void Spawn()
    {
        float Randx = Random.Range(-6.69f,7.4f);
        float rand= Random.Range(0,2);
	float y = -0.49f;
        if (rand == 1)
        {
            y = -1.86f;
        }
  	
        Vector3 randPosition = new Vector3(Randx,y,0);

	if (rand == 0)
	{
	    Instantiate(target_up, randPosition, Quaternion.identity);
	}
	if (rand == 1)
	{
            Instantiate(target_down, randPosition, Quaternion.identity);
	}
    }

    public void IncrementScore()
    {
        score++;
        print(score);

        scoreText.text = score.ToString();
    }
}
