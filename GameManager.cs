using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Player player1 = new Player();
        Player player2 = new Player();

        player1.InitializePlayer("Player One", 50);
        player2.InitializePlayer("Player Two", 75);

        player1.Health(20);
        player2.Health(true);

        Player.ShowPlayerCount();

    }

}
