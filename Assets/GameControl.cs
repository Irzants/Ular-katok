using UnityEngine;
using UnityEngine.UI;

public class GameControl : MonoBehaviour
{

    private static GameObject whoWinsTextShadow, player1MoveText, player2MoveText;

    private static GameObject player1, player2;

    public static int diceSideThrown = 0;
    public static int player1StartWaypoint = 0;
    public static int player2StartWaypoint = 0;

    public static bool gameOver = false;

    private Transform respawnPoint;

    // Use this for initialization
    void Start()
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

            if (player1StartWaypoint + diceSideThrown == 4)
            {
                moveToLadderOrSnakePoint(player: player1, destinationPointIndex: 15, diceSideThrown: diceSideThrown);
            }
            if (player1StartWaypoint + diceSideThrown == 14)
            {
                moveToLadderOrSnakePoint(player: player1, destinationPointIndex: 9, diceSideThrown: diceSideThrown);
            }
            if (player1StartWaypoint + diceSideThrown == 18)
            {
                moveToLadderOrSnakePoint(player: player1, destinationPointIndex: 23, diceSideThrown: diceSideThrown);
            }
            if (player1StartWaypoint + diceSideThrown == 25)
            {
                moveToLadderOrSnakePoint(player: player1, destinationPointIndex: 17, diceSideThrown: diceSideThrown);
            }
            if (player1StartWaypoint + diceSideThrown == 27)
            {
                moveToLadderOrSnakePoint(player: player1, destinationPointIndex: 34, diceSideThrown: diceSideThrown);
            }
            if (player1StartWaypoint + diceSideThrown == 37)
            {
                moveToLadderOrSnakePoint(player: player1, destinationPointIndex: 43, diceSideThrown: diceSideThrown);
            }
            if (player1StartWaypoint + diceSideThrown == 40)
            {
                moveToLadderOrSnakePoint(player: player1, destinationPointIndex: 19, diceSideThrown: diceSideThrown);
            }
            if (player1StartWaypoint + diceSideThrown == 47)
            {
                moveToLadderOrSnakePoint(player: player1, destinationPointIndex: 35, diceSideThrown: diceSideThrown);
            }
            player1.GetComponent<FollowThePath>().moveAllowed = false;
            player1StartWaypoint = player1.GetComponent<FollowThePath>().waypointIndex - 1;
        }

        if (player2.GetComponent<FollowThePath>().waypointIndex >
            player2StartWaypoint + diceSideThrown)
        {

            player2MoveText.gameObject.SetActive(false);
            player1MoveText.gameObject.SetActive(true);

            if (player2StartWaypoint + diceSideThrown == 4)
            {
                moveToLadderOrSnakePoint(player: player2, destinationPointIndex: 15, diceSideThrown: diceSideThrown);
            }
            if (player2StartWaypoint + diceSideThrown == 14)
            {
                moveToLadderOrSnakePoint(player: player2, destinationPointIndex: 9, diceSideThrown: diceSideThrown);
            }
            if (player2StartWaypoint + diceSideThrown == 18)
            {
                moveToLadderOrSnakePoint(player: player2, destinationPointIndex: 23, diceSideThrown: diceSideThrown);
            }
            if (player2StartWaypoint + diceSideThrown == 25)
            {
                moveToLadderOrSnakePoint(player: player2, destinationPointIndex: 17, diceSideThrown: diceSideThrown);
            }
            if (player2StartWaypoint + diceSideThrown == 27)
            {
                moveToLadderOrSnakePoint(player: player2, destinationPointIndex: 34, diceSideThrown: diceSideThrown);
            }
            if (player2StartWaypoint + diceSideThrown == 37)
            {
                moveToLadderOrSnakePoint(player: player2, destinationPointIndex: 43, diceSideThrown: diceSideThrown);
            }
            if (player2StartWaypoint + diceSideThrown == 40)
            {
                moveToLadderOrSnakePoint(player: player2, destinationPointIndex: 19, diceSideThrown: diceSideThrown);
            }
            if (player2StartWaypoint + diceSideThrown == 47)
            {
                moveToLadderOrSnakePoint(player: player2, destinationPointIndex: 35, diceSideThrown: diceSideThrown);
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
        switch (playerToMove)
        {
            case 1:
                player1.GetComponent<FollowThePath>().moveAllowed = true;
                break;

            case 2:
                player2.GetComponent<FollowThePath>().moveAllowed = true;
                break;
        }
    }

    void moveToLadderOrSnakePoint(GameObject player, int destinationPointIndex, int diceSideThrown)
    {
        if (player.name == "Player1")
        {
            MovePlayer(1);
        }
        else if (player.name == "Player2")
        {
            MovePlayer(2);
        }

        var playerInstance = player.GetComponent<FollowThePath>();
        playerInstance.transform.position = Vector2.MoveTowards(playerInstance.transform.position, playerInstance.waypoints[destinationPointIndex].transform.position, 1f * Time.deltaTime);
        // playerInstance.transform.position = player1.GetComponent<FollowThePath>().waypoints[destinationPointIndex].transform.position;
        playerInstance.waypointIndex = destinationPointIndex;
        player.GetComponent<FollowThePath>().waypointIndex += 1;
    }

}
