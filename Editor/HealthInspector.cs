using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(HealthComponent))]
public class HealthInspector : Editor {

    public override void OnInspectorGUI()
    {
        base.OnInspectorGUI();

        if (GUILayout.Button("Hit"))
        {
            ((HealthComponent)target).Healt -= 10;
        }
    }
}
