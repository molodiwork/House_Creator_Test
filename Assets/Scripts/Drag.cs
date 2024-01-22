using UnityEngine;
using System.Collections;


public class Drag : MonoBehaviour
{
    private Vector3 distance;

    void OnMouseDown()
    {
        distance = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, Camera.main.WorldToScreenPoint(transform.position).z)) - transform.position;
    }

    void OnMouseDrag()
    {
        Vector3 distance_to_screen = Camera.main.WorldToScreenPoint(transform.position);
        Vector3 pos_move = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, distance_to_screen.z));
        transform.position = new Vector3(pos_move.x - distance.x, transform.position.y, pos_move.z - distance.z);

    }
}