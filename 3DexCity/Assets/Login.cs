using UnityEngine;
using System.Collections;

public class Login : MonoBehaviour {
 #region Variables
    //static variables 
    public static string Email="";
    public static string Password = "";

    //private variable 
    private string CreateAccountURL="";
    private string LoginURL = "";
    private string ConfirmEmail = "";
    private string ConfirmPassword = "";
    private string CPassword = "";
    private string CEmail = "";

    //public variable 
    public string CurentMenu = "Login";

    //GUI text section
    public float X;
    public float Y;
    public float Width;
    public float Height;

#endregion
    // Use this for initialization
    void Start () {
	}//end start 
	
    //main GUI Function
    void OnGUI()
    {   //if our curent menu is = login, then display the login menue 
        //by calling our loginGUI function. else, display the 
        //create accunt GUI by calling its function
   if (CurentMenu == "Login")
        {   //call LonginGUI function 
            LonginGUI();
        }//end if
   else
        if (CurentMenu == "CreateAccount")
        {  //call  CreateAccountGUI function 
            CreateAccountGUI();
        }//end else if

    }//end GUI

#region Custom methods
//this method will login the account
    void LonginGUI()
    {  //create box simulates window
        GUI.Box(new Rect(150, 50,(Screen.width/4)+ 350,(Screen.height/4)+ 250), "Login");
        //create login and create acciunt buttons
        //open create account window

        if (GUI.Button(new Rect(290, 360, 120, 25), "Create account")) 
        {
            CurentMenu = "CreateAccount";

        }//end button
        if (GUI.Button(new Rect(500, 360, 120, 25), "Login")) 
        {
        }//end button
        //email field
        GUI.Label(new Rect(330, 100, 229, 23), "Email");
        Email = GUI.TextField(new Rect(330,125,229,23),Email);
        //password field
        GUI.Label(new Rect(330, 150, 229, 23), "Password");
        Password = GUI.TextField(new Rect(330, 170, 229, 23), Password);
    }//end LoginGUI

    //this method will be the GUI for creating the account
    void CreateAccountGUI()
    {//create box simulates window
        GUI.Box(new Rect(150, 50, (Screen.width / 4) + 350, (Screen.height / 4) + 250), "Create Account");

        //email field
        GUI.Label(new Rect(330, 100, 229, 23), "Email");
        CEmail = GUI.TextField(new Rect(330, 125, 229, 23), CEmail);
        //password field
        GUI.Label(new Rect(330, 150, 229, 23), "Password");
        CPassword = GUI.TextField(new Rect(330, 175, 229, 23), CPassword);
        //email field
        GUI.Label(new Rect(330, 200, 229, 23), "Confirm Email");
        ConfirmEmail = GUI.TextField(new Rect(330, 225, 229, 23), ConfirmEmail);
        //password field
        GUI.Label(new Rect(330, 250, 229, 23), "Confirm Password");
        ConfirmPassword = GUI.TextField(new Rect(330, 275, 229, 23), ConfirmPassword);

        //create login and create acciunt buttons
        //open create account window

        if (GUI.Button(new Rect(290, 360, 120, 25), "Create account"))
        {
         if (ConfirmEmail==CEmail && ConfirmPassword==CPassword)
            {
                //startCoroutine();
            }
         else
            {
                //startCoroutine();
            }

        }//end create account
        if (GUI.Button(new Rect(500, 360, 120, 25), "Back"))
        {
            CurentMenu = "Login";

        }//end button
    } //end CreateAccountGUI
#endregion
}//end class
