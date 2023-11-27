

using UnityEngine;
using TMPro;
using System.IO;

public class Score : MonoBehaviour
{
    public TextMeshProUGUI myScoreText;
    public TextMeshProUGUI gameOverScoreText;
    public TextMeshProUGUI highScoreText;
    public TextMeshProUGUI gameOverhighScoreText;
    public TextMeshProUGUI starText;

    private int ScoreNum;
    private int HighScoreNum;
    public int StarNum;
    private string scoreFilePath;

    private void Awake()
    {
        scoreFilePath = Application.persistentDataPath + "/Score4.json";
        Debug.Log(scoreFilePath);
    }

    void Start()
    {
        LoadScore();
        UpdateScoreText();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Star"))
        {
            SoundManager.inst.PlaySound(SoundName.s3);
            ScoreNum += 10;
            StarNum += 10;
            Destroy(collision.gameObject);
            UpdateScoreText();

            if (ScoreNum > HighScoreNum)
            {
                HighScoreNum = ScoreNum;
                UpdateScoreText();
            }
        }
    }


    public void UpdateScoreText()
    {
        myScoreText.text = ScoreNum.ToString();
        highScoreText.text = "HIGH SCORE: " + "<b>" + HighScoreNum + "</b>";
        gameOverScoreText.text = "Score: " + ScoreNum;
        gameOverhighScoreText.text = "High Score: " + "<b>" + HighScoreNum + "</b>";
        starText.text = "STAR: "+StarNum;
        SaveScore();
    }

   

    private void SaveScore()
    {
        ScoreData scoreData = new ScoreData { ScoreNum = ScoreNum, HighScoreNum = HighScoreNum,StarNum=StarNum };
        string jsonData = JsonUtility.ToJson(scoreData);
        File.WriteAllText(scoreFilePath, jsonData);
    }

    private void LoadScore()
    {
        if (File.Exists(scoreFilePath))
        {
            string jsonData = File.ReadAllText(scoreFilePath);
            ScoreData scoreData = JsonUtility.FromJson<ScoreData>(jsonData);
            HighScoreNum = scoreData.HighScoreNum;
            StarNum = scoreData.StarNum;
        }
    }

    public void ResetScore()
    {
        ScoreNum = 0; 
        UpdateScoreText();
    }
}

[System.Serializable]
public class ScoreData
{
    public int ScoreNum;
    public int HighScoreNum;
    public int StarNum;
}
