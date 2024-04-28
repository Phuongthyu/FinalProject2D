using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            
            SceneManager.LoadScene("Level_1");
        }
    }
}