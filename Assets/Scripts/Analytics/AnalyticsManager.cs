using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Analytics;

public class AnalyticsManager : Singleton<AnalyticsManager>
{
    public void OnPlayerDead(int levelID, string playerName)
    {
        Analytics.CustomEvent("Player Dead", new Dictionary<string, object>
        {
            {"level", levelID},
            {"player", playerName}
        });
    }

    public void OnLevelStarted(int levelID, string playerName)
    {
        Analytics.CustomEvent("Level Started", new Dictionary<string, object>
        {
            {"level", levelID},
            {"player", playerName}
        });
    }
}
