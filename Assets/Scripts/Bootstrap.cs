using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Boots : MonoBehaviour
{
    void Start()
    {
        Application.targetFrameRate = 60;
        SceneManager.LoadScene(1);
    }
}
