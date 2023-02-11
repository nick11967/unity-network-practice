using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NetworkTest2 : MonoBehaviour
{
    async private void Start()
    {
        Network nw = new Network();

        List<Network.Room> rooms = await nw.GetRooms();

        Debug.Log("Finish Get");

        for (int i = 0; i < rooms.Count; i++)
        {
            Debug.Log("Room #" + (i + 1).ToString());
            Debug.Log(rooms[i].code);
            Debug.Log(rooms[i].title);
            Debug.Log(rooms[i].player_num);
            Debug.Log(rooms[i].turninfo);
            List<int> deck = rooms[i].deck;
            string deckS = "";
            for (int j = 0; j < deck.Count; j++)
                deckS = deckS + deck[j].ToString() + ", ";
            Debug.Log(deckS);
            List<Network.Player> players = rooms[i].players;
            for (int j = 0; j < players.Count; j++)
            {
                Debug.Log("Player #" + (j + 1).ToString());
                Debug.Log(players[j].nickname);
                Debug.Log(players[j].room_code);
                List<int> card = players[j].cards;
                string cardS = "";
                for (int k = 0; k < card.Count; k++)
                {
                    cardS = cardS + card[k].ToString() + ", ";
                }
                Debug.Log(cardS);
            }
        }

        /*        List<Network.Player> players = await nw.GetPlayers();
                for (int j = 0; j < players.Count; j++)
                {
                    Debug.Log("Player #" + (j + 1).ToString());
                    Debug.Log(players[j].nickname);
                    Debug.Log(players[j].room_code);
                    List<int> card = players[j].cards;
                    string cardS = "";
                    for (int k = 0; k < card.Count; k++)
                    {
                        cardS = cardS + card[k].ToString() + ", ";
                    }
                    Debug.Log(cardS);
                }*/


    }
}
