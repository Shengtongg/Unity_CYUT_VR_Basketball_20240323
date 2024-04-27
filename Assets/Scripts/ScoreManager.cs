using TMPro;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    [SerializeField, Header("���Ƥ�r")]
    private TMP_Text textScore;

    private string basketballName = "�x�y";
    private int score;


    private void OnTriggerEnter(Collider other)
    {
        //print(other.name);
        if (other.name.Contains(basketballName))
        {
            score += 2;
            //print($"<color=#f93>���� : {score}</color>");
            textScore.text = $"SCORE - {score}";
        }
    }
}
