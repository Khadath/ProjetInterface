﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndLevel : MonoBehaviour
{
    public bool isLimit;
    public string nameNextLevel;
    public string nameReloadLevel;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Ball")
        {
            GameObject.Find("GameManager").GetComponent<GameManager>().End();
            if (isLimit)
            {
                SceneManager.LoadScene(nameReloadLevel);
            }
            else
            {
                Debug.Log("Here");
                SceneManager.LoadScene(nameNextLevel);
            }
        }
    }
}
