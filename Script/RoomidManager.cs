using UnityEngine;
using UnityEngine.UI;

public class RoomidManager : MonoBehaviour
{

    [SerializeField]
    InputField RoomIdText;

    private void Start()
    {
        RoomIdText.onValueChanged.AddListener(ValidateInput);
    }
    private void ValidateInput(string input)
    {
        if (input.Length > 10)
        {
            RoomIdText.text = input.Substring(0, 10);
        }

        for (int i = 0; i < RoomIdText.text.Length; i++)
        {
            if (!char.IsDigit(RoomIdText.text[i]))
            {
                RoomIdText.text = RoomIdText.text.Remove(i, 1);
                i--;
            }
        }
    }

    public void CreateButton()
    {
        string Idtext = RoomIdText.text;
        print("Enter Room ID" + Idtext);

        string Checkloginmessage = CheckloginInfo(Idtext);
    }
    public void JoinButton()
    {
        string Idtext = RoomIdText.text;
        print("Enter Room ID" + Idtext);

        string Checkloginmessage = CheckloginInfo(Idtext);
    }
    public void RoomListButton()
    {
        string Idtext = RoomIdText.text;
        print("Enter Room ID" + Idtext);

        string CheckRoomListmessage = CheckRoomList(Idtext);
    }

    private string CheckloginInfo(string Idtext)
    {
        string returnString = "";
        if (string.IsNullOrEmpty(Idtext))
        {
            returnString = "Room Id is Empty";
        }
        else
        {
            returnString = "";
            print("Player Page is open");
        }
        print("Return String---" + returnString);
        return returnString;
    }
    private string CheckRoomList(string Idtext)
    {
        string returnString = "";
        if (string.IsNullOrEmpty(Idtext))
        {
            returnString = "Room Id is Empty";
        }
        else
        {
            returnString = "";
            print("Next Page is open====>");
        }
        print("Return String---" + returnString);
        return returnString;
    }
}
