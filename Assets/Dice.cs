using System.Collections;
using UnityEngine;

public class Dice : MonoBehaviour
{

    private Sprite[] diceSides;
    private SpriteRenderer rend;
    private int whosTurn = 1;
    private bool coroutineAllowed = true;
    private static GameObject player1MoveText, player2MoveText;
    private static GameObject player1, player2;
    public Transform respawnPoint1;
    public Transform respawnPoint2;
    private bool diceClickAllowed = false;

    // Use this for initialization
    private void Start()
    {
        player1 = GameObject.Find("Player1");
        player2 = GameObject.Find("Player2");
        player1MoveText = GameObject.Find("Player1MoveText");
        player2MoveText = GameObject.Find("Player2MoveText");
        rend = GetComponent<SpriteRenderer>();
        diceSides = Resources.LoadAll<Sprite>("DiceSides/");
        rend.sprite = diceSides[5];
    }

    private void OnMouseDown()
    {
        if (!GameControl.gameOver && coroutineAllowed && diceClickAllowed)
        {
            coroutineAllowed = false;
            StartCoroutine("RollTheDice");
        }
    }

    /// <summary>
    /// Update is called every frame, if the MonoBehaviour is enabled.
    /// </summary>
    void Update()
    {
        if (player1MoveText.activeSelf)
        {
            this.transform.position = this.respawnPoint1.transform.position;
        }
        else
        {
            this.transform.position = this.respawnPoint2.transform.position;
        }

        if (coroutineAllowed && player1.GetComponent<FollowThePath>().moveAllowed == false && player2.GetComponent<FollowThePath>().moveAllowed == false)
        {
            this.diceClickAllowed = true;
        }
        else
        {
            this.diceClickAllowed = false;
        }
    }

    private IEnumerator RollTheDice()
    {
        int randomDiceSide = 0;
        for (int i = 0; i <= 20; i++)
        {
            randomDiceSide = Random.Range(0, 6);
            rend.sprite = diceSides[randomDiceSide];
            yield return new WaitForSeconds(0.05f);
        }

        GameControl.diceSideThrown = randomDiceSide + 1;
        if (whosTurn == 1)
        {
            GameControl.MovePlayer(1);
        }
        else if (whosTurn == -1)
        {
            GameControl.MovePlayer(2);
        }
        whosTurn *= -1;
        coroutineAllowed = true;
    }
}
