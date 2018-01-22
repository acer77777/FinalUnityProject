using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {

    bool end = false;
    public float delay = 3f;
    public GameObject Complete;

    public void win()
    {
        Complete.SetActive(true);
    }

    public void endgame()
    {
        if (end == false) { 
        Debug.Log("Game Over");
        end = true;
            Invoke("restart",delay);
    }
    }
    void restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
    }

