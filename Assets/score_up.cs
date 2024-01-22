using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class score_up : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other) {
        GetComponent<AudioSource>().Play();
        score.current_score += 1;
    }
}
