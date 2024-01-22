using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateTree : MonoBehaviour
{
    public GameObject[] tree;
    public GameObject currentTree;

    public void SpawnTree()
    {
        Ray ray = new Ray(transform.position, transform.forward);
        RaycastHit hit;

        if (Physics.Raycast(ray, out hit))
        {
            if (hit.transform.tag == ("Ground"))
            {
                int rand = Random.Range(0, 2);
                Vector3 point = new Vector3(hit.point.x, hit.point.y, hit.point.z);
                currentTree = Instantiate(tree[rand], point, Quaternion.Euler(0f, 0f, 0f));
            }
         }
    }
}
