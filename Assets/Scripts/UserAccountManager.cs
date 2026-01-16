using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using PlayFab;
using PlayFab.ClientModels;

public class UserAccountManager : MonoBehaviour
{
    public static UserAccountManager instance;

    public static UnityEvent OnSignedIn = new UnityEvent();
    public static UnityEvent<string, string> OnUserDataRetrieved = new UnityEvent<string, string>(); 
    string PlayFabId;
    
    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }
    public void createAccount(string email, string password, string username)
    {
        var request = new RegisterPlayFabUserRequest
        {
            Email = email,
            Password = password,
            Username = username,
            RequireBothUsernameAndEmail = true
        };

        PlayFabClientAPI.RegisterPlayFabUser(request,
            response =>
            {
                Debug.Log("Account created successfully for user: " + response.Username);
                PlayFabId = response.PlayFabId;
                OnSignedIn.Invoke();
            },
            error =>
            {
                Debug.LogError("Account creation failed: " + error.GenerateErrorReport());
            });
    }

    public void login(string email, string password)
    {
        var request = new LoginWithEmailAddressRequest
        {
            Email = email,
            Password = password
        };

        PlayFabClientAPI.LoginWithEmailAddress(request,
            response =>
            {
                Debug.Log("Login successful for user: " + response.PlayFabId);
                PlayFabId = response.PlayFabId;
                OnSignedIn.Invoke();
            },
            error =>
            {
                Debug.LogError("Login failed: " + error.GenerateErrorReport());
            });
    }

    public void getUserData(string key)
    {
        PlayFabClientAPI.GetUserData(new GetUserDataRequest()
        {
            PlayFabId = PlayFabId,
            Keys = new List<string>() { key }
        },
        response =>
        {
            if (response.Data != null && response.Data.ContainsKey(key))
            {
                Debug.Log("User data retrieved");
                OnUserDataRetrieved.Invoke(key, response.Data[key].Value);
            }
            else
            {
                Debug.Log("No data found for key: " + key);
            }
        },
        error =>
        {
            Debug.LogError("Failed to get user data: " + error.GenerateErrorReport());
        });
    }

    public void setUserData(string key, string value)
    {
        var request = new UpdateUserDataRequest()
        {
            Data = new Dictionary<string, string>()
            {
                { key, value }
            }
        };

        PlayFabClientAPI.UpdateUserData(request,
            response =>
            {
                Debug.Log("User data updated successfully");
            },
            error =>
            {
                Debug.LogError("Failed to update user data: " + error.GenerateErrorReport());
            });
    }
}
