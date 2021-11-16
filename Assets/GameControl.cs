using UnityEngine;
using UnityEngine.UI;

public class GameControl : MonoBehaviour {

    private static GameObject whoWinsTextShadow, player1MoveText, player2MoveText;

    private static GameObject player1, player2;

    public static int diceSideThrown = 0;
    public static int player1StartWaypoint = 0;
    public static int player2StartWaypoint = 0;

    public static bool gameOver = false;

    private Transform respawnPoint;

    // Use this for initialization
    void Start () 
    {
        player1StartWaypoint = 0;
        player2StartWaypoint = 0;
        diceSideThrown = 0;

        whoWinsTextShadow = GameObject.Find("WhoWinsText");
        player1MoveText = GameObject.Find("Player1MoveText");
        player2MoveText = GameObject.Find("Player2MoveText");

        player1 = GameObject.Find("Player1");
        player2 = GameObject.Find("Player2");

        player1.GetComponent<FollowThePath>().moveAllowed = false;
        player2.GetComponent<FollowThePath>().moveAllowed = false;

        whoWinsTextShadow.gameObject.SetActive(false);
        player1MoveText.gameObject.SetActive(true);
        player2MoveText.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (player1.GetComponent<FollowThePath>().waypointIndex > 
            player1StartWaypoint + diceSideThrown)
        {
            player1MoveText.gameObject.SetActive(false);
            player2MoveText.gameObject.SetActive(true);
            
        
            if(player1StartWaypoint+diceSideThrown == 4)
            {
                player1.GetComponent<FollowThePath>().transform.position = player1.GetComponent<FollowThePath>().waypoints[15].transform.position;
                player1.GetComponent<FollowThePath>().waypointIndex = 15;
                player1.GetComponent<FollowThePath>().waypointIndex +=1;
                MovePlayer(1);
            }
            if(player1StartWaypoint+diceSideThrown == 14)
            {
                player1.GetComponent<FollowThePath>().transform.position = player1.GetComponent<FollowThePath>().waypoints[9].transform.position;
                player1.GetComponent<FollowThePath>().waypointIndex = 9;
                player1.GetComponent<FollowThePath>().waypointIndex +=1;
                MovePlayer(1);
            }
            if(player1StartWaypoint+diceSideThrown == 18)
            {
                player1.GetComponent<FollowThePath>().transform.position = player1.GetComponent<FollowThePath>().waypoints[23].transform.position;
                player1.GetComponent<FollowThePath>().waypointIndex = 23;
                player1.GetComponent<FollowThePath>().waypointIndex +=1;
                MovePlayer(1);
            }
            if(player1StartWaypoint+diceSideThrown == 25)
            {
                player1.GetComponent<FollowThePath>().transform.position = player1.GetComponent<FollowThePath>().waypoints[17].transform.position;
                player1.GetComponent<FollowThePath>().waypointIndex = 17;
                player1.GetComponent<FollowThePath>().waypointIndex +=1;
                MovePlayer(1);
            }
            if(player1StartWaypoint+diceSideThrown == 27)
            {
                player1.GetComponent<FollowThePath>().transform.position = player1.GetComponent<FollowThePath>().waypoints[34].transform.position;
                player1.GetComponent<FollowThePath>().waypointIndex = 34;
                player1.GetComponent<FollowThePath>().waypointIndex +=1;
                MovePlayer(1);
            }
            if(player1StartWaypoint+diceSideThrown == 37)
            {
                player1.GetComponent<FollowThePath>().transform.position = player1.GetComponent<FollowThePath>().waypoints[43].transform.position;
                player1.GetComponent<FollowThePath>().waypointIndex = 43;
                player1.GetComponent<FollowThePath>().waypointIndex +=1;
                MovePlayer(1);
            }
            if(player1StartWaypoint+diceSideThrown == 40)
            {
                player1.GetComponent<FollowThePath>().transform.position = player1.GetComponent<FollowThePath>().waypoints[19].transform.position;
                player1.GetComponent<FollowThePath>().waypointIndex = 19;
                player1.GetComponent<FollowThePath>().waypointIndex +=1;
                MovePlayer(1);
            }
            if(player1StartWaypoint+diceSideThrown == 47)
            {
                player1.GetComponent<FollowThePath>().transform.position = player1.GetComponent<FollowThePath>().waypoints[35].transform.position;
                player1.GetComponent<FollowThePath>().waypointIndex = 35;
                player1.GetComponent<FollowThePath>().waypointIndex +=1;
                MovePlayer(1);
            }
            player1.GetComponent<FollowThePath>().moveAllowed = false;
            player1StartWaypoint = player1.GetComponent<FollowThePath>().waypointIndex - 1;
        }

        if (player2.GetComponent<FollowThePath>().waypointIndex >
            player2StartWaypoint + diceSideThrown)
        {

            player2MoveText.gameObject.SetActive(false);
            player1MoveText.gameObject.SetActive(true);
            
            if(player2StartWaypoint+diceSideThrown == 4)
            {
                player2.GetComponent<FollowThePath>().transform.position = player2.GetComponent<FollowThePath>().waypoints[15].transform.position;
                player2.GetComponent<FollowThePath>().waypointIndex = 15;
                player2.GetComponent<FollowThePath>().waypointIndex +=1;
                MovePlayer(2);
            }
            if(player2StartWaypoint+diceSideThrown == 14)
            {
                player2.GetComponent<FollowThePath>().transform.position = player2.GetComponent<FollowThePath>().waypoints[9].transform.position;
                player2.GetComponent<FollowThePath>().waypointIndex = 9;
                player2.GetComponent<FollowThePath>().waypointIndex +=1;
                MovePlayer(2);
            }
            if(player2StartWaypoint+diceSideThrown == 18)
            {
                player2.GetComponent<FollowThePath>().transform.position = player2.GetComponent<FollowThePath>().waypoints[23].transform.position;
                player2.GetComponent<FollowThePath>().waypointIndex = 23;
                player2.GetComponent<FollowThePath>().waypointIndex +=1;
                MovePlayer(2);
            }
            if(player2StartWaypoint+diceSideThrown == 25)
            {
                player2.GetComponent<FollowThePath>().transform.position = player2.GetComponent<FollowThePath>().waypoints[17].transform.position;
                player2.GetComponent<FollowThePath>().waypointIndex = 17;
                player2.GetComponent<FollowThePath>().waypointIndex +=1;
                MovePlayer(2);
            }
            if(player2StartWaypoint+diceSideThrown == 27)
            {
                player2.GetComponent<FollowThePath>().transform.position = player2.GetComponent<FollowThePath>().waypoints[34].transform.position;
                player2.GetComponent<FollowThePath>().waypointIndex = 34;
                player2.GetComponent<FollowThePath>().waypointIndex +=1;
                MovePlayer(2);
            }
            if(player2StartWaypoint+diceSideThrown == 37)
            {
                player2.GetComponent<FollowThePath>().transform.position = player2.GetComponent<FollowThePath>().waypoints[43].transform.position;
                player2.GetComponent<FollowThePath>().waypointIndex = 43;
                player2.GetComponent<FollowThePath>().waypointIndex +=1;
                MovePlayer(2);
            }
            if(player2StartWaypoint+diceSideThrown == 40)
            {
                player2.GetComponent<FollowThePath>().transform.position = player2.GetComponent<FollowThePath>().waypoints[19].transform.position;
                player2.GetComponent<FollowThePath>().waypointIndex = 19;
                player2 .GetComponent<FollowThePath>().waypointIndex +=1;
                MovePlayer(2);
            }
            if(player2StartWaypoint+diceSideThrown == 47)
            {
                player2.GetComponent<FollowThePath>().transform.position = player2.GetComponent<FollowThePath>().waypoints[35].transform.position;
                player2.GetComponent<FollowThePath>().waypointIndex = 35;
                player2.GetComponent<FollowThePath>().waypointIndex +=1;
                MovePlayer(2);
            }
            
            player2.GetComponent<FollowThePath>().moveAllowed = false;
            player2StartWaypoint = player2.GetComponent<FollowThePath>().waypointIndex - 1;
        }

        if (player1.GetComponent<FollowThePath>().waypointIndex == 
            player1.GetComponent<FollowThePath>().waypoints.Length)
        {
            whoWinsTextShadow.gameObject.SetActive(true);
            whoWinsTextShadow.GetComponent<Text>().text = "Player 1 Wins";
            gameOver = true;
        }

        if (player2.GetComponent<FollowThePath>().waypointIndex ==
            player2.GetComponent<FollowThePath>().waypoints.Length)
        {
            whoWinsTextShadow.gameObject.SetActive(true);
            player1MoveText.gameObject.SetActive(false);
            player2MoveText.gameObject.SetActive(false);
            whoWinsTextShadow.GetComponent<Text>().text = "Player 2 Wins";
            gameOver = true;
        }
    }

    public static void MovePlayer(int playerToMove)
    {
        switch (playerToMove) { 
            case 1:
                player1.GetComponent<FollowThePath>().moveAllowed = true;
                break;

            case 2:
                player2.GetComponent<FollowThePath>().moveAllowed = true;
                break;
        }
    }

}
