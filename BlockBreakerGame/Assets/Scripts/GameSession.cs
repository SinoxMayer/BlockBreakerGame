using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class GameSession : MonoBehaviour

{


    [Range(0.5f,5f)] [SerializeField] float gameSpeed = 1f;
    [SerializeField] int pointsPerBlock = 83 ;
    [SerializeField] int currentScore = 0;
    [SerializeField] TextMeshProUGUI scoreText;


    private void Awake()
    {

        // burda bir singleton metodu kullanarak bir onceki ekrandan bir sonraki ekran veri bırakıyoruz . 
        // bir onceki ekrandaki bir sonrakine gecerken baska bir object varsa yok ediliyor 
        int gameStatusCount = FindObjectsOfType<GameSession>().Length;


 
        if (gameStatusCount > 1)
        {
            gameObject.SetActive(false);
            Destroy(gameObject);
        }
        else
        {

            DontDestroyOnLoad(gameObject);
            
        }
    }


    // Start is called before the first frame update
    void Start()
    {
        scoreText.text = currentScore.ToString();
    }

    // Update is called once per frame
    void Update()
    {

        // update için yazıyorum çünkü canlı statüs cekicem frame frame bilicez

        Time.timeScale = gameSpeed;
     
    }
    public void AddToScore()

    {

        currentScore += pointsPerBlock;
        scoreText.text = currentScore.ToString();


    }
    public void ResetScoreOnStart()
    {

        Destroy(gameObject);

    }
}
