/*
Keep track of the points scored in the game

Gilberto Echeverria
2023-03-01
*/

using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
using System.Collections;

public class Score : MonoBehaviour
{
    [SerializeField] TMP_Text tmpObj;
    [SerializeField] int maxScore;

    CreateBalls creator;
    int score;

    // Start is called before the first frame update
    void Start()
    {
        creator = GetComponent<CreateBalls>();
        score = 0;
    }

    public void AddPoints(int amount)
    {
        score += amount;
        // Udate the text displayed on the screen
        tmpObj.text = "Score: " + score;
        //Debug.Log("New score: " + score);

        if (score == maxScore) {
            Finish();
        }
    }

    void Finish()
    {
        creator.StopBalls();
        tmpObj.text += "\n\nYou Won!!";
        StartCoroutine(ChangeScene());
    }

    IEnumerator ChangeScene()
    {
        yield return new WaitForSeconds(2f);
        SceneManager.LoadScene("Victory");
    }
}
