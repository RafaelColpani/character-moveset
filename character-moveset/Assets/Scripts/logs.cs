using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class logs 
{
    public static void Log(this Object myObj, object msg)
    {
        Debug.Log($"{myObj.name}: {msg}");
    }
}
