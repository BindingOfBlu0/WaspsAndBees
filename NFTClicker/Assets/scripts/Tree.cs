using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tree : MonoBehaviour
{
    public Sprite Tree1, Tree2;

    // Update is called once per frame
     private void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
            GetComponent<SpriteRenderer>().sprite = Tree1;
        if (Input.GetKeyDown(KeyCode.D))
            GetComponent<SpriteRenderer>().sprite = Tree2;
    }
}
