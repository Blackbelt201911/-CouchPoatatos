using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using Unity.VisualScripting;
using UnityEditorInternal;
using UnityEngine;

public class MoveToTheCrossair : MonoBehaviour
{
    public float Speed = 12;
    void Update()
    {
        Vector2 Mpos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        transform.position = Vector2.MoveTowards(transform.position, Mpos, Speed * Time.deltaTime);
    }
}
