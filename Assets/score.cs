using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class score : MonoBehaviour
{
    public static int current_score = 0;

    public static int best_score = 0;
    // Start is called before the first frame update
    void Start()
    {
        current_score = 0;
    }

    // Update is called once per frame
    void Update()
    {
        GetComponent<Text>().text = current_score.ToString();
    }
}
