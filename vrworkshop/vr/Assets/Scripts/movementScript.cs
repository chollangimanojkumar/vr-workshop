using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movementScript : MonoBehaviour
{
    public GameObject Sphere;
    public Texture2D[] images;
    int imgnum = 0;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void next()
    {


        Sphere.GetComponent<Renderer>().material.mainTexture = images[imgnum];
        imgnum = (imgnum + 1) % images.Length;




    }
    public void prev()
    {
        
        if (imgnum == 0)
        {
            imgnum = images.Length;
        }
        else
        {
            imgnum = (imgnum - 1) % images.Length;
        }
        Sphere.GetComponent<Renderer>().material.mainTexture = images[imgnum];

    }
}
