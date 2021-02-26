using System.Collections;
using UnityEngine;

public static class AudioFader
{

    public static IEnumerator StartFade(AudioSource audioSource, float fadeDuration, float targetVolume)
    {

        float currentTime = 0;
        float startVolume = audioSource.volume;

        while (currentTime < fadeDuration)
        {
            currentTime += Time.deltaTime;
            audioSource.volume = Mathf.Lerp(startVolume, targetVolume, currentTime / fadeDuration);
            yield return null;
        }
        yield break;

    }
}
