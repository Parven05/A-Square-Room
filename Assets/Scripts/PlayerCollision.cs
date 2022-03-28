using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class PlayerCollision : MonoBehaviour
{
    public AudioSource deathSound;
    public GameObject effect;

    private void Start()
    {
        gameObject.GetComponent<SpriteRenderer>().enabled = true;
        gameObject.GetComponent<TrailRenderer>().enabled = true;
    }
    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.transform.tag == "Enemy")
        {
            Instantiate(effect, transform.position, Quaternion.identity);
            deathSound.Play();
            gameObject.GetComponent<SpriteRenderer>().enabled = false;
            gameObject.GetComponent<TrailRenderer>().enabled = false;
            StartCoroutine("RestartGameCo");
        }
    }
    public IEnumerator RestartGameCo()
    {
        yield return new WaitForSeconds(0.5f);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 0);
    }
}