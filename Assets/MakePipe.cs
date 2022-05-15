using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MakePipe : MonoBehaviour
{
    public GameObject Column;
    public float timerDiff;
    float timer = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if (timer > timerDiff)
        {
            GameObject newpipe = Instantiate(Column);
            newpipe.transform.position = new Vector3(7, Random.Range(-0.48f, 2.23f), 0);
            timer = 0;
            Destroy(newpipe, 10.0f);
        }
    }
}
