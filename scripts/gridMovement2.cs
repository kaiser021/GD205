using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gridMovement2: MonoBehaviour
{

    public Transform playerTransform;
    public Transform hazard;
    public Transform[] hazards;


    Vector3 initPos;


    public AudioClip deathClip;


    AudioSource speaker;


    public Transform block;


    Vector3 newPosition;


    public Material trailMat;


    public Transform fieldParent;


    public Vector3 fwd, bwd, lft, rgt, up, dwn;





    void Start()
    {
        initPos = playerTransform.position;
        speaker = GetComponent<AudioSource>();
    }


    void Update()
    {


        controls();



        updatePosition();
        checkHazards();


        createTrail();

    }


    public void controls()
    {

        newPosition = playerTransform.position;

        if (Input.GetKeyDown(KeyCode.W))
        {

            newPosition = playerTransform.position + fwd;


        }


        if (Input.GetKeyDown(KeyCode.S))
        {
            newPosition = playerTransform.position + bwd;


        }
        if (Input.GetKeyDown(KeyCode.A))
        {


            newPosition += lft;
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            newPosition += rgt;
        }
        if (Input.GetKeyDown(KeyCode.Q))
        {
            newPosition += dwn;
        }
        if (Input.GetKeyDown(KeyCode.E))
        {
            newPosition += up;
        }

    }

    public void updatePosition()
    {

        //if (newPosition.y <= 5 && newPosition.y >= 0 
        // && newPosition.x >= 0 && newPosition.x <= -18.33333 
        // && newPosition.z >= -25 && newPosition.z <= 0)
        {


            if (newPosition != block.position)
            {
                playerTransform.position = newPosition;
            }
        }
    }

    public void checkHazards()
    {
        for (int i = 0; i < hazards.Length; i++)
        {
            if (playerTransform.position == hazards[i].position)
            {
                playerTransform.position = initPos;
                speaker.PlayOneShot(deathClip, 0.6f);
            }
        }

        if (playerTransform.position == hazard.position)
        {
            playerTransform.position = initPos;
            speaker.PlayOneShot(deathClip, 0.6f);
        }

    }

    void createTrail()
    {
        for (int i = 0; i < fieldParent.childCount; i++)
        {
            if (playerTransform.position == fieldParent.GetChild(i).position)
            {




                fieldParent.GetChild(i).gameObject.GetComponent<Renderer>().material.color = Color.red;

            }

        }
    }

}