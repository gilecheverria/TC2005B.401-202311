/*
Script to display information comming from another scenes
Using PlayerPrefs to store and retrieve data

Also using LERP to interpolate between color values

Gilberto Echeverria
2023-03-27
*/

using UnityEngine;
using TMPro;

public class ShowScore : MonoBehaviour
{
    [SerializeField] TMP_Text finalText;
    [SerializeField] float delay;
    [SerializeField] Color targetColor;

    Color baseColor;

    float elapsed;
    bool finished = false;

    // Start is called before the first frame update
    void Start()
    {
        // Get the information from the global storage
        int seconds = PlayerPrefs.GetInt("seconds", 0);        
        // Update the text
        finalText.text = "You took " + seconds + " seconds";
        // Initialize variables for the color change
        elapsed = 0;
        baseColor = finalText.color;
    }

    void Update()
    {
        // Only once, after the time has passed
        if(elapsed > delay && !finished)
        {
            finalText.text += "\nGood job!";
            finished = true;
        }
        // While the flag is off, do the interpolation
        if (!finished)
        {
            // Convert the time into a proportion in the range 0 to 1
            float t = elapsed / delay;
            // Apply the proportion to the colors
            finalText.color = Color.Lerp(baseColor, targetColor, t);
        }

        // Update elapsed time
        elapsed += Time.deltaTime;
    }
}
