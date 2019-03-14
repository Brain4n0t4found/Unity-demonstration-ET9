using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    Animator anim;
    int facing;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        facing = 5;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.S))
        {
            facing = 2;

        }
        else
        {
            facing = 1;
        }
        anim.SetInteger("facing", facing); //Commentaire de test
    }
}
