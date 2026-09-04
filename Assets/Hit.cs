using UnityEngine;
using TMPro;

public class Hit : MonoBehaviour
{
    public int score = 0;
    public TMP_Text ScoreBoard;
    private void OnCollisionEnter(Collision c)
    {
        Arrow arrow = c.gameObject.GetComponent<Arrow>();
        if (arrow != null && arrow.has_scored == false)
        {
            score += 10;
            arrow.has_scored = true;
            ScoreBoard.text = "Score: " + score;
        }
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        ScoreBoard.text = "Score: " + score;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
