using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LoginManager : MonoBehaviour
{
    [SerializeField]
    InputField EnternameText;

    [SerializeField]
    Text changecolour;

    [SerializeField]
    GameObject nameLoginPage, RoomIdPage;

    public void SubmitButton()
    {
        string nametext = EnternameText.text;
        print("Enter Name" + nametext);

        string Checkloginmessage = CheckloginInfo(nametext);
    }

    private void Start()
    {
        changecolour.text = "Connecting...";
        changecolour.color = Color.red;
    }

    private string CheckloginInfo(string nametext)
    {
        string returnString = "";
        if(string.IsNullOrEmpty(nametext))
        {
            returnString = "Username is Empty";
        }
        else
        {
            returnString = "";
            nameLoginPage.SetActive(false);
            RoomIdPage.SetActive(true);
        }
        print("Return String---" +  returnString);
        return returnString;
    }
}
