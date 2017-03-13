using UnityEngine;

public class HoverhighlightedUnit : MonoBehaviour {

    public GameObject selector;

    // Use this for initialization
    void Start ()
    {
        if (!selector)
            Debug.LogError("No reference for selector");

        if (selector.activeInHierarchy)
            selector.SetActive(false);
    }

    void OnMouseOver()
    {
        if (!selector.activeInHierarchy)
            selector.SetActive(true);
    }

    void OnMouseExit()
    {
        if (selector.activeInHierarchy)
            selector.SetActive(false);
    }


}