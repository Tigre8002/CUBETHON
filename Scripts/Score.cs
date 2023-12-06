using TMPro;
using UnityEngine;

public class Score : MonoBehaviour
{
    public Transform player;
    public GameObject panelUI;
    private TextMeshProUGUI scoreText;

    void Start() {
        scoreText = GetComponent<TextMeshProUGUI>();
        GameManager.panelUI = panelUI;
    }

    void Update()
    {
        scoreText.text = player.position.z.ToString("0");
    }
}
