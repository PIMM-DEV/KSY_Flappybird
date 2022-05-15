using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MakeBap : MonoBehaviour
{
    public GameObject jong;
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
            GameObject newjong = Instantiate(jong);
            newjong.transform.position = new Vector3(6, Random.Range(0.694f, -1.01f), 0);
            timer = 0;
            Destroy(newjong, 10.0f);
        }
    }
}

