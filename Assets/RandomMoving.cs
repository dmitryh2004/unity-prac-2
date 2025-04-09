using System;
using System.Collections.Generic;
using UnityEngine;

public class RandomMoving : MonoBehaviour
{
    public Transform pointsParent;
    System.Random randomizer = new System.Random();
    private List<Transform> points = new List<Transform>();
    public int range = 5;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int childCount = pointsParent.childCount;
        for (int i = 0; i < childCount; i++)
        {
            points.Add(pointsParent.GetChild(i));
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (getRandomNumber() == 5)
        {
            Vector3 position = points[randomizer.Next(0, points.Count)].transform.position;
            transform.position = position;
        }
    }

    int getRandomNumber()
    {
        return randomizer.Next(1, range);
    }
}
