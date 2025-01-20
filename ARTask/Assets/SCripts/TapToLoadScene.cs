using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.XR.ARFoundation;

public class TapToLoadScene : MonoBehaviour
{
    public string nextSceneName; // Name of the scene to load
    

    private void OnMouseDown()
    {
        // Check if the object is clicked
        Debug.Log($"{gameObject.name} clicked!");

        // Load the next scene
        
        SceneManager.LoadScene(nextSceneName);
    }
}
