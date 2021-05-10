using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FakePlayer : MonoBehaviour
{
    [SerializeField] List<string> playerNames = new List<string>() { "Underlord", "Doom", "Invoker", "Outworld Devourer", "Viper", "Naga Siren", "Bristleback", "Riki", "Silencer", "Techies" };

    public void PlayerDead()
    {
        AnalyticsManager.Instance.OnPlayerDead(Random.Range(1, 10), playerNames[Random.Range(0, playerNames.Count)]);
    }

    public void PlayLevel()
    {
        AnalyticsManager.Instance.OnLevelStarted(Random.Range(1, 10), playerNames[Random.Range(0, playerNames.Count)]);
    }
}
