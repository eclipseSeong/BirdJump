using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class birdJump : MonoBehaviour
{
    Rigidbody2D rb;

    public float JumpPower;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            GetComponent<AudioSource>().Play();
            rb.velocity = Vector2.up * JumpPower;
        }
    }

    private void OnCollisionEnter2D(Collision2D other) {
        SceneManager.LoadScene("GameOverScene");
        if(score.best_score < score.current_score){
             score.best_score = score.current_score;   
        }

    }
}
