using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    public AudioSource coinSound;
    public int coinValue = 1;
    public GameObject effect;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            ScoreManager.instance.ChangeScore(coinValue);
            coinSound.Play();
            Instantiate(effect, transform.position, Quaternion.identity);
        }
    }
}    
