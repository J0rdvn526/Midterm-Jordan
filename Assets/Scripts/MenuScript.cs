using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuScript : MonoBehaviour
{

    public void goToGame() {
        SceneManager.LoadScene("gameplay");
    }
}
