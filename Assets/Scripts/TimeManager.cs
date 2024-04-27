using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class TimeManager : MonoBehaviour
{
    [SerializeField, Header("�ɶ���r")]
    private TMP_Text textTime;
    [SerializeField, Header("�˼Ʈɶ�")]
    private float timeTotal = 60;
    [SerializeField, Header("�e���C������")]
    private GameObject canvasFinalObject;
    [SerializeField, Header("�ˬd�ϰ���ƺ޲z��")]
    private GameObject scoreManagerObject;
    [SerializeField, Header("���s�ͦ��x�y")]
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
