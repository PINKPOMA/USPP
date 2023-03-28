using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button : MonoBehaviour
{
    public void EmailButton()
    {
        string Emailadd= "Choi82354@gmail.com";
        Application.OpenURL("mailto:" + Emailadd);
    }
 
}
