using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DifficultyChanger : MonoBehaviour
{
    public void difficulty (int scale)
    {
        GameManager.diff = (scale);
    }

}
