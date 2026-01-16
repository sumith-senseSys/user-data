using UnityEngine;

public class UserProfile : MonoBehaviour
{
    [SerializeField] ProfileData profileData;


    void OnEnable()
    {
        UserAccountManager.OnSignedIn.AddListener(OnSignedIn);
        UserAccountManager.OnUserDataRetrieved.AddListener(OnUserDataRetrieved);
    }

    void OnDisable()
    {
        UserAccountManager.OnSignedIn.RemoveListener(OnSignedIn);
        UserAccountManager.OnUserDataRetrieved.RemoveListener(OnUserDataRetrieved);
    }

    void OnSignedIn()
    {
        getProfileData();
    }
    [ContextMenu("Load Profile Data")]

    void getProfileData()
    {
        
        UserAccountManager.instance.getUserData("ProfileData");
    }
     void OnUserDataRetrieved(string key, string value)
    {
        if (key == "ProfileData")
        {
            profileData = JsonUtility.FromJson<ProfileData>(value);
            Debug.Log("Profile Data Loaded: " + value);
        }
    }

    [ContextMenu("set Profile Data")]
    void setProfileData()
    {
        UserAccountManager.instance.setUserData("ProfileData", JsonUtility.ToJson(profileData));
    }

   

}

[System.Serializable]
public class ProfileData
{
    public string displayName;
    public int level;
    public int experiencePoints;
}
