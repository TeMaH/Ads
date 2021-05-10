using System.Collections;
using UnityEngine;
using UnityEngine.Advertisements;

public class BannerAd : MonoBehaviour
{
    public string gameId = "4122857";
    public string surfacingId = "";

    void Start()
    {
        Advertisement.Initialize(gameId, true);
    }

    public void ShowBannerWhenInitialized()
    {
        if (Advertisement.isInitialized)
        {
            Advertisement.Banner.SetPosition(BannerPosition.BOTTOM_CENTER);
            Advertisement.Banner.Show(surfacingId);
        }
    }
}