  using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; // Text
using UnityEngine.SceneManagement; // Reload Scene

public class PlayerScore : MonoBehaviour
{ 
    private Text scoreText; // variable that will track our Text score

    private int score = 0;

    // Start is called before the first frame update
    private void Awake()
    {
        scoreText = GameObject.Find("ScoreText").GetComponent<Text>();
        scoreText.text = "0";
    }

    private void OnTriggerEnter2D(Collider2D target)
    {
        if (target.tag == "Bomb")
        {
            transform.position = new Vector2(0, 100); // cause we want to take away our Player of the field of veiw
            target.gameObject.SetActive(false); // setActive false the bomb

            //reload the scene
            StartCoroutine(RestartGame());
        }

        if (target.tag == "Fruit")
        {
            target.gameObject.SetActive(false); // setActive false the fruit
            score++;
            scoreText.text = score.ToString();

        }
    }


    IEnumerator RestartGame()
    {
        yield return new WaitForSecondsRealtime(2f);
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

} // class
































