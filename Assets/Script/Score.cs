
using UnityEngine;
using TMPro;

public class Score : MonoBehaviour
{
    public TextMeshProUGUI ScoreText;
    public Transform Player;
    public int score;

    public void Update()
    {
        Score_Display();
    }
    public void Score_Display()
    {
        float f = Player.position.z - 100f;
        
        ScoreText.text = f.ToString("0");
    }

}
