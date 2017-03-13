using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(HealthComponent))]
public class HealthEditor : Editor {

    int damage = 100;

    public override void OnInspectorGUI()
    {
        base.OnInspectorGUI();

        damage = EditorGUILayout.IntField(new GUIContent("Set damage:"), damage);

        if (GUILayout.Button("Hit"))
        {
            ((HealthComponent)target).Healt -= damage;
        }
    }
}
