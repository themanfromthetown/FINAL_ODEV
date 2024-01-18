using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Dusman_Carpısma : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D carpilanNesne)
    {
        if (carpilanNesne.gameObject.CompareTag("Player"))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
}