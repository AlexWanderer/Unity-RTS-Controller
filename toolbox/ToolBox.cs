using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class Toolbox
{
    static Toolbox()
    {
        scriptList = new List<MonoBehaviour>();
    }

    private static List<MonoBehaviour> scriptList;

    /// <summary>
    /// Adds only one instance of given script, two script of the same type are not allowed
    /// </summary>
    /// <param name="script"></param>
    public static void AddScript(MonoBehaviour script)
    {


        //if (! CheckForDuplicates<>()) TODO: jak sprawdzić typ obiektu które nie jest typem MonoBehaviour
        scriptList.Add(script);
    }

    private static bool CheckForDuplicates<T>() where T : MonoBehaviour
    {
        for (int i = 0; i < scriptList.Count; i++)
        {
            if (scriptList[i] is T)
                return true;
        }

        return false;
    }

    /// <summary>
    /// Search and return given type of Script if there is no one which match then return null
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <returns>T or null</returns>

    public static T GetScript<T>() where T : MonoBehaviour
    {
        for (int i = 0; i < scriptList.Count; i++)
        {
            if (scriptList[i] is T)
                return (T) scriptList[i];
        }
        return null;
    }
}