using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NetworkTest2 : MonoBehaviour
{
    async private void Start()
    {
        Network nw = new Network();

        List<Network.Room> rooms = await nw.GetRooms();

        for(int i = 0; i < rooms.Count; i++)
        {
            Debug.Log(rooms[i].code);
            Debug.Log(rooms[i].title);
            Debug.Log(rooms[i].player_num);
            Debug.Log(rooms[i].turninfo);
            List<int> deck = rooms[i].deck;
            Debug.Log(deck.ToString());
            int count = rooms[i].players.Count;
        }
        Debug.Log(rooms);
    }
}
