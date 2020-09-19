using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WebURLScript : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {

    }

    public void btnOne()
    {
        Application.OpenURL("https://www.facebook.com/profile.php?id=100004305275178");
    }

    public void btnTwo()
    {
        Application.OpenURL("https://www.linkedin.com/in/ravi-kumar-93276117b");
    }

    public void btnthree()
    {
        Application.OpenURL("https://www.instagram.com/ravi27280/");
    }

    public void btnfour()
    {
        Application.OpenURL("www.google.com");
    }
    // Update is called once per frame
    void Update()
    {

    }
}