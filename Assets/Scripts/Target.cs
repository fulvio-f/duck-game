using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target : MonoBehaviour
{
    public GameManager gameManager;
    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject, 2f);
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();  //Find the script "GameManager" inside the object"GameManager
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseDown()
    {
        gameManager.IncrementScore();

        Destroy(gameObject);
    }

}
