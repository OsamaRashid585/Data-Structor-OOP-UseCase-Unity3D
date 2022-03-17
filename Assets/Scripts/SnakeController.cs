using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SnakeController : MonoBehaviour
{
    private Stack<GameObject> mystack;
    public GameObject CubePre;
    int pos=0;
    void Start()
    {
        mystack = new Stack<GameObject>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            mystack.Push(Instantiate(CubePre, transform.position + new Vector3(0, pos, 0), Quaternion.identity));
            pos++;
        }
        if (Input.GetMouseButtonDown(1))
        {
            Destroy(mystack.Pop());
            pos--;
           
        }
    }

}
