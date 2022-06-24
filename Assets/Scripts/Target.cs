using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Target : MonoBehaviour
{
    public GameManager gameManager;

    // Start is called before the first frame update
    void Start()
    {
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();  //Find the script "GameManager" inside the object"GameManager
        int diff2 = gameManager.PassDiff();
        Destroy(gameObject, 1.5f*diff2);

    }

    private void OnMouseDown()
    {
        gameManager.IncrementScore();

        Destroy(gameObject);
    }

}
