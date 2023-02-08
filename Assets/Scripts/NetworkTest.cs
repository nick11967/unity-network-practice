using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
using System.Threading;
using System.Threading.Tasks;

public class NetworkTest : MonoBehaviour
{
    async void Start()
    {
        Debug.Log("Start");
        Network nw = new Network();
        string player1 = "Apple";
        string player2 = "Banana";
        string player3 = "Chat";
        string player4 = "Dino";
        string player5 = "Eggsome";

        
        Debug.Log("GetisNNExist Test");
        bool isExist = await nw.GetisNNExist(player1);
        Debug.Log("isExist ¤¡");
        Debug.Log(isExist);
        Debug.Log("GetisNNExist Done");

        Thread.Sleep(3000);
        
        Debug.Log("PostNewPlayer Test");
        nw.PostNewPlayer(player1);
        Debug.Log("PostNewPlayer Done");

        Thread.Sleep(3000);

        Debug.Log("PostNewRoom Test");
        string newRoomcode = await nw.PostNewRoom(4);
        Debug.Log("newRoomcode ¤¡");
        Debug.Log(newRoomcode);
        Debug.Log("PostNewRoom Done");

        Thread.Sleep(3000);

        Debug.Log("GetisRoomFull Test");
        bool isFull = await nw.GetisRoomFull(newRoomcode);
        Debug.Log("isFull ¤¡");
        Debug.Log("GetisRoomFull Done");

        Thread.Sleep(3000);

        Debug.Log("PutPlayertoRoom Test");
        nw.PutPlayerToRoom(newRoomcode, player1);
        var roominfo1 = await nw.GetRoomInfo(newRoomcode);
        Debug.Log("RoomInfo");
        Debug.Log(roominfo1);

        Thread.Sleep(3000);

        nw.PostNewPlayer(player2);
        nw.PutPlayerToRoom(newRoomcode, player2);
        nw.PostNewPlayer(player3);
        nw.PutPlayerToRoom(newRoomcode, player3);
        nw.PostNewPlayer(player4);
        nw.PutPlayerToRoom(newRoomcode, player4);
        var roominfo2 = await nw.GetRoomInfo(newRoomcode);
        Debug.Log("RoomInfo");
        Debug.Log(roominfo1);
        Debug.Log("PutPlayertoRoom Done");


    }
}