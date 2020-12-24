using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Comments : MonoBehaviour
{
    public void GetCodeFromGit()
    {
        Debug.Log("fetch and update from master in github desktop");
    }

    public void SubmitCodeToGit()
    {
        Debug.Log("push to your branch and create pull request");
    }

    public void UpdateMaster()
    {
        Debug.Log("copy paste from the wanted files");
        Debug.Log("jk, don't. ");
    }
}
