using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExParentClass : MonoBehaviour
{
    protected int protectedValue;
}

public class ChildClass : ExParentClass
{
    private void Start()
    {
        Debug.Log("Protected Value frum Child Class : " + protectedValue);
    }
}

