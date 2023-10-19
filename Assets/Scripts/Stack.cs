using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class Stack : MonoBehaviour
{
    int yOffset = -1;
    public GameObject stackBlockPrefab; // Renamed for consistency.
    public GameObject firstBlock;
    public Stack<GameObject> blockHolder = new Stack<GameObject>();

    private void Start()
    {
        blockHolder.Push(firstBlock);
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            AddBlock();
        }
        
    }

    private void AddBlock()
    {
        var block = Instantiate(stackBlockPrefab);
        block.transform.position = new Vector3(0, yOffset, 0);

        if (blockHolder.Count > 0)
        {
            block.GetComponent<SpringJoint>().connectedBody = blockHolder.Peek().GetComponent<Rigidbody>();
            block.GetComponent<SpringJoint>().connectedAnchor = new Vector3(0, yOffset, 0);
        }

        yOffset += -1;
        blockHolder.Push(block);
    }
}
