using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class TimeManager : MonoBehaviour
{
    [SerializeField, Header("時間文字")]
    private TMP_Text textTime;
    [SerializeField, Header("倒數時間")]
    private float timeTotal = 60;
    [SerializeField, Header("畫布遊戲結束")]
    private GameObject canvasFinalObject;
    [SerializeField, Header("檢查區域分數管理器")]
    private GameObject scoreManagerObject;
    [SerializeField, Header("按鈕生成籃球")]
    private Button btnSpawn;

    private void Update()
    {
        CountDown();
    }

    private void CountDown()
    {
        timeTotal -= Time.deltaTime;
        timeTotal = Mathf.Clamp(timeTotal,0,100);
        textTime.text = $"TIME - {timeTotal.ToString("F0")}";

        if (timeTotal == 0) GameOver();
    }

    private void GameOver()
    {
        canvasFinalObject.SetActive(true);
        scoreManagerObject.SetActive(false);
        btnSpawn.interactable = false;
    }
}
