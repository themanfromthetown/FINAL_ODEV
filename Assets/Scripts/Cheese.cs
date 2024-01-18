using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.SocialPlatforms.Impl;

public class Cheese : MonoBehaviour
{


    private void OnCollisionEnter2D(Collision2D collider)
    {
        if (collider is null)
        {
            throw new ArgumentNullException(nameof(collider));
        }

        if (!collider.gameObject.CompareTag("Player"))
        {
            return;
        }
        
        gameObject.SetActive(false);



    }
}

