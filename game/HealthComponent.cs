using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthComponent : MonoBehaviour {

    Texture2D foregroundTexture;
    Texture2D backgroundTexture;

    UnitManager _unitManager;

    const int HEALTH = 100;
    int currentHealth = HEALTH;

    // Use this for initialization
    void Start () {
        foregroundTexture = new Texture2D(1, 1);
        foregroundTexture.SetPixel(0, 0, Color.green);
        foregroundTexture.Apply();

        backgroundTexture = new Texture2D(1, 1);
        backgroundTexture.SetPixel(0, 0, Color.black);
        backgroundTexture.Apply();

        _unitManager = Toolbox.GetScript<UnitManager>();
    }
	
	// Update is called once per frame
	void Update ()
    {
        

	}

    void OnGUI()
    {

        if (_unitManager.isSelected(this.gameObject))
        {
            Vector3 unitPos = Camera.main.WorldToScreenPoint(this.transform.position);

            GUI.DrawTexture(new Rect(unitPos.x - HEALTH / 2.0f, Screen.height - unitPos.y - 5 / 2.0f, HEALTH, 5), backgroundTexture, ScaleMode.StretchToFill);
            GUI.DrawTexture(new Rect(unitPos.x - HEALTH / 2.0f, Screen.height - unitPos.y - 5 / 2.0f, currentHealth, 5), foregroundTexture, ScaleMode.StretchToFill);
        }
            
    }
}
