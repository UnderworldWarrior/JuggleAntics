﻿using UnityEngine;

public class BallSpawner : MonoBehaviour {

	public GameObject ballFab;
	public GameObject[] spawner;
	public int force;
	private Rigidbody rb;

    public static int bcount = 0;



    // Use this for initialization
    void Start () {
		spawnBall();
	}

    void spawnBall() {

        GameObject spawn = spawner[0];

        int choice = Random.Range(0, 4);

        switch (choice) {
            case 1:
                spawn = spawner[1];
                break;
            case 2:
                spawn = spawner[2];
                break;
            case 3:
                spawn = spawner[3];
                break;
            default:
                spawn = spawner[0];
                break;
        }

//	for(int i=0;i < 5; i++)
	//{

        GameObject ball = Instantiate(ballFab, spawn.transform.position, spawn.transform.rotation);
        rb = ball.GetComponent<Rigidbody>();
        rb.AddForce(spawn.transform.forward * force);
        bcount++;

        Debug.Log("bcount is " + bcount);
//	}


    }



}
