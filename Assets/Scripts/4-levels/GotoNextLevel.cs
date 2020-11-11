using UnityEngine;
using UnityEngine.SceneManagement;

public class GotoNextLevel : MonoBehaviour {
    [SerializeField] string sceneName;
    [SerializeField] NumberField scoreField;

    private void OnTriggerEnter2D(Collider2D collision) {
        GameStatus.playerScore = scoreField.GetNumber(); // Keep the score for the next level
        SceneManager.LoadScene(sceneName);    // Input can either be a serial number or a name; here we use name.
    }
}
