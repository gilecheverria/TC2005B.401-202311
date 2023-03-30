/*
Keep track of the points scored in the game
The game finishes after a predefined number of points

Gilberto Echeverria
2023-03-01
*/

using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class Score : MonoBehaviour
{
    // Reference to a text object to display the points
    [SerializeField] TMP_Text tmpScore;
    // Reference to a GUI objet that will be enabled when the game finishes
    [SerializeField] GameObject victoryLabel;
    [SerializeField] int maxScore;

    CreateBalls creator;
    int score;
    int seconds;

    // Start is called before the first frame update
    void Start()
    {
        creator = GetComponent<CreateBalls>();
        score = 0;
        seconds = 0;
    }

    void Update()
    {
        InvokeRepeating("AddSecond", 1, 1);
    }

    void AddSecond()
    {
        seconds++;
    }

    public void AddPoints(int amount)
    {
        score += amount;
        // Udate the text displayed on the screen
        tmpScore.text = "Score: " + score;
        //Debug.Log("New score: " + score);

        if (score == maxScore) {
            Finish();
        }
    }

    void Finish()
    {
        creator.StopBalls();
        // Enable a hidden object to show the victory label
        victoryLabel.SetActive(true);
        // Store the information about the seconds elapsed
        PlayerPrefs.SetInt("seconds", seconds);

        // Initiate a parallel process that will wait before taking an action
        StartCoroutine(ChangeScene());
    }

    // Go to another scene after a set time
    IEnumerator ChangeScene()
    {
        yield return new WaitForSeconds(2f);
        SceneManager.LoadScene("Victory");
    }
}
