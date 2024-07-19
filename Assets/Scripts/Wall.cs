using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wall : MonoBehaviour
{
    public GameObject block;
    public int width = 15;
    public int height = 8;
    void Start()
    {
        for (int y=1; y<height; ++y)
        {
            for (int x=0; x<width; ++x)
            {
                Vector3 offset = new Vector3(x, y, 10);
                Instantiate(block, transform.position + offset, Quaternion.identity);
            }
        }        
    }
}
