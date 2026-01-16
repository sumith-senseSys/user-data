using UnityEngine;
using UnityEngine.UI;

public class UICreateAccount : MonoBehaviour
{
  string username, email, password;

  public void onUsernameChanged(string value)
  {
    username = value;
  }
    public void onEmailChanged(string value)
    {
        email = value;
    }
    public void onPasswordChanged(string value)
    {
        password = value;
    }

    public void onCreateAccountButtonClicked()
    {
        UserAccountManager.instance.createAccount(email, password, username);
    }
}
