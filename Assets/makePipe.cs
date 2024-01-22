using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class makePipe : MonoBehaviour
{
    public GameObject pipe;

    public float timeDiff;

     float timer = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        timer += Time.deltaTime;
        if(timer > timeDiff){
            GameObject newpipe = Instantiate(pipe);
            newpipe.transform.position = new Vector3(3, Random.Range(10f, 14.0f),0);
            timer = 0;

            Destroy(newpipe, timeDiff*2f);
        }
       
    }
}
