using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using PlayFab.ClientModels;
using PlayFab;

public class playfabmanager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        login();
    }

    void login()
    {
        var request = new LoginWithCustomIDRequest
        {
            CustomId = SystemInfo.deviceUniqueIdentifier,
            CreateAccount = true
        };
        PlayFabClientAPI.LoginWithCustomID(request, Onsuccess, OnError);

    }
    void Onsuccess(LoginResult result)
    {
        Debug.Log("successful login/account creat!");
    }
    void OnError(PlayFabError error)
    {
        Debug.Log("error while logging in/creating account!");
        Debug.Log(error.GenerateErrorReport());
    }
    public void Sendleaderboard(int score)
    {
        var request = new UpdatePlayerStatisticsRequest
        {
            Statistics = new List<StatisticUpdate>
            {
                new StatisticUpdate
                {
                    StatisticName = "block score",
                    Value = score

                }
            }
        };
        PlayFabClientAPI.UpdatePlayerStatistics(request, OnLeaderboardUpdate, OnError);
    } 
    void OnLeaderboardUpdate(UpdatePlayerStatisticsResult result)
    {
        Debug.Log("successful leaderboard sent");
    }
}
