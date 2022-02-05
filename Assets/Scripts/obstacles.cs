using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class obstacles : MonoBehaviour
{
    float maxTime;
    float timer;
    public GameObject ob1;
    public GameObject ob2;
    public GameObject ob3;
    public GameObject ob4;
    public GameObject ob5;
    public GameObject ob6;
    int chooseObstacle;

    // Start is called before the first frame update
    void Start()
    {
        maxTime = 1f;
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if (timer >= maxTime)
        {
            GenerateObstacle();
            timer = 0;
        }

    }
    void GenerateObstacle()
    {
        chooseObstacle = Random.Range(1, 7);
        if (chooseObstacle == 1) {
            GameObject newObstacle = Instantiate(ob1);
        }
        if (chooseObstacle == 2)
        {
            GameObject newObstacle = Instantiate(ob2);
        }
        if (chooseObstacle == 3)
        {
            GameObject newObstacle = Instantiate(ob3);
        }
        if (chooseObstacle == 4)
        {
            GameObject newObstacle = Instantiate(ob4);
        }
        if (chooseObstacle == 5)
        {
            GameObject newObstacle = Instantiate(ob5);
        }
        if (chooseObstacle == 6)
        {
            GameObject newObstacle = Instantiate(ob6);
        }
    }
}
