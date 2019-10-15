using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// The HUD
/// </summary>
public class HUD : MonoBehaviour
{
    // score support
    Text scoreText;
    int score = 0;
    const string ScorePrefix = "Score: ";

    /// <summary>
    /// Use this for initialization
    /// </summary>
    void Start()
    {
        // initialize score text
        scoreText = GameObject.FindGameObjectWithTag("ScoreText").GetComponent<Text>();
        scoreText.text = ScorePrefix + score;
        //Fish game obj 
        //  GameObject.FindGameObjectWithTag("Fish");
        Fish fish = GameObject.FindGameObjectWithTag("Fish").GetComponent<Fish>();
        fish.AddPointAddedListener(onPointAdded);
    }

    /// <summary>
    /// Updates the score
    /// </summary>
    /// <param name="points">points to add</param>
    public void onPointAdded(int point)
    {
        score += point;
        scoreText.text = ScorePrefix + score;
    }

}
