using UnityEngine;

public class UILoginAccount : MonoBehaviour
{
 
    string username, password;

    public void onUsernameChanged(string value)
    {
        username = value;
    }
    public void onPasswordChanged(string value)
    {
        password = value;
    }

    public void onLoginButtonClicked()
    {
        UserAccountManager.instance.login(username, password);
    }
}
