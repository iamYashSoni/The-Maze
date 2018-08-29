using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class SignPost : MonoBehaviour
{
    public GameObject signPost;
    public Scene maze;

    public void ResetScene()
        {
            // Reset the scene when the user clicks the sign post
            

        }
    public void OnSignPostClicked()
        {
            maze = SceneManager.GetActiveScene();
            SceneManager.LoadScene(maze.name);
        } 
}
