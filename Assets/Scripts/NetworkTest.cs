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
        string user_nickname = "goldenring";

        
        Debug.Log("GetisNNExist Test");
        var isExist = await nw.GetisNNExist(user_nickname);
        Debug.Log("isExist ¤¡");
        Debug.Log(isExist);
        Debug.Log("GetisNNExist Done");
        
        Debug.Log("PostNewPlayer Test");
        nw.PostNewPlayer(user_nickname);
        Debug.Log("PostNewPlayer Done");

        Debug.Log("PostNewRoom Test");
        var newRoomcode = await nw.PostNewRoom(4);
        Debug.Log("newRoomcode ¤¡");
        Debug.Log(newRoomcode);
        Debug.Log("PostNewRoom Done");

        Debug.Log("Put");


    }
}