using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playermono : MonoBehaviour
{

    // Use this for initialization
    private Quaternion player_orientation;
    private Animator player_animator;
    Camera Main_Camera;
    private Vector3 displacement = new Vector3(0.02f, 0f, 0f);
    private GameObject wife;
    private Animator wife_animator;
    void Start()
    {
        player_animator = transform.GetComponent<Animator>();
        Main_Camera = Camera.main;
        wife = GameObject.Find("mother");
        wife_animator = wife.transform.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKey(KeyCode.D))
        {
            Main_Camera.transform.position += displacement;
            player_orientation = Quaternion.Euler(0f, 0f, 0f);
            transform.rotation = player_orientation;

            player_animator.SetBool("run", true);

            wife_rightmovement();


        }
        else if (Input.GetKey(KeyCode.A))
        {
            Main_Camera.transform.position -= displacement;
            player_orientation = Quaternion.Euler(0f, -180f, 0f);
            transform.rotation = player_orientation;
            player_animator.SetBool("run", true);

            wife_leftmovement();
        }
        else
        {
            player_animator.SetBool("run", false);
            wife.transform.position = new Vector3(wife.transform.position.x,-1.5f,0f);
            wife_animator.SetBool("run",false);
        }


    }

    private void wife_rightmovement()
    {
        if (Vector3.Distance(transform.position, wife.transform.position) > 3f)
        {

            Debug.Log("near");
            wife.transform.position += displacement;
            wife.transform.rotation = player_orientation;
            wife.transform.position = new Vector3(wife.transform.position.x,-1.68f,0f);
            wife_animator.SetBool("run", true);
        }

    }

    private void wife_leftmovement()
    {
        if (Vector3.Distance(transform.position, wife.transform.position) > 3f)
        {
            wife.transform.position -= displacement;
            wife.transform.rotation = player_orientation;
            wife.transform.position = new Vector3(wife.transform.position.x,-1.68f,0f);
            wife_animator.SetBool("run", true);
        }
    }
}
