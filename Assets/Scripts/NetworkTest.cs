using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
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
        var isExist = await nw.GetisNNExist(player1);
        Debug.Log("isExist ¤¡");
        Debug.Log(isExist);
        Debug.Log("GetisNNExist Done");
        
        Debug.Log("PostNewPlayer Test");
        nw.PostNewPlayer(player1);
        Debug.Log("PostNewPlayer Done");

        Debug.Log("PostNewRoom Test");
        var newRoomcode = await nw.PostNewRoom(4);
        Debug.Log("newRoomcode ¤¡");
        Debug.Log(newRoomcode);
        Debug.Log("PostNewRoom Done");

        Debug.Log("GetisRoomFull Test");
        var isFull = await nw.GetisRoomFull(newRoomcode);
        Debug.Log("isFull ¤¡");
        Debug.Log("GetisRoomFull Done");

        Debug.Log("PutPlayertoRoom Test");
        nw.PutPlayerToRoom(newRoomcode, player1);
        var roominfo1 = await nw.GetRoomInfo(newRoomcode);
        Debug.Log("RoomInfo");
        Debug.Log(roominfo1);
        Debug.Log("PutPlayertoRoom Done");




    }
}