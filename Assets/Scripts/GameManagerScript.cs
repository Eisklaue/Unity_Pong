using UnityEngine;
using System.Collections;

public class GameManagerScript : MonoBehaviour {

    [SerializeField]
    BallScript gameBall;

    int playerOneScore, playerTwoScore;

	// Use this for initialization
	void Start () {
        
        playerOneScore = 0;
        playerTwoScore = 0;
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void GoalScored(int playerNumber)
    {
        
        if(playerNumber == 1)
            playerOneScore++;
        else if (playerNumber ==2)
            playerTwoScore++;


        if(playerOneScore == 3)
            GameOver(1);
        else if (playerTwoScore ==3)
            GameOver(2);

    } 

    void GameOver(int winner)
    {
        playerOneScore = 0;
        playerTwoScore = 0; 
        gameBall.Reset ();
    }
}
