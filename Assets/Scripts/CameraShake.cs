using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraShake : MonoBehaviour
{
    [SerializeField] private float duration = 0.15f; // Default duration
    [SerializeField] private float magnitude = 0.1f; // Default magnitude

    private Vector3 originalPos; // The original position of the camera

    // Shake the camera for the specified duration and magnitude
    public void Shake(float customDuration, float customMagnitude)
    {
        duration = customDuration;
        magnitude = customMagnitude;
        originalPos = transform.localPosition;
        StartCoroutine(Shaking());
    }

    // Coroutine to perform the camera shake
    private IEnumerator Shaking()
    {
        float elapsed = 0f;

        while (elapsed < duration)
        {
            float x = Random.Range(-1f, 1f) * magnitude;
            float y = Random.Range(-1f, 1f) * magnitude;

            transform.localPosition = originalPos + new Vector3(x, y, 0);

            elapsed += Time.deltaTime;

            yield return null;
        }

        // Reset the camera position to its original position
        transform.localPosition = originalPos;
    }
}
