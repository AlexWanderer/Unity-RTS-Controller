﻿using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(HealthComponent))]
public class HealthEditor : Editor {

    public override void OnInspectorGUI()
    {
        base.OnInspectorGUI();

        if (GUILayout.Button("Hit"))
        {
            ((HealthComponent)target).Healt -= 10;
        }
    }
}
