using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OviraImageSwitcher : MonoBehaviour
{
    [System.Serializable]
    public class ImagePair
    {
        public CanvasGroup originalImage;
        public CanvasGroup smileImage;
    }

    [Header("Image Pairs")]
    public ImagePair[] imagePairs;

    [Header("Timing")]
    // 顯示時間（秒）
    public float displayDuration = 0.6f;
    // 動畫時間（秒）
    public float transitionDuration = 0.8f;

    private void Start()
    {
        foreach (var pair in imagePairs)
        {
            // 初始化：只顯示 original
            pair.originalImage.alpha = 1f;
            pair.originalImage.gameObject.SetActive(true);

            pair.smileImage.alpha = 0f;
            pair.smileImage.gameObject.SetActive(false);

            // 為每組圖片啟動獨立的輪播協程
            StartCoroutine(SwitchLoop(pair));
        }
    }

    IEnumerator SwitchLoop(ImagePair pair)
    {
        while (true)
        {
            yield return new WaitForSeconds(displayDuration);
            yield return StartCoroutine(CrossFade(pair.originalImage, pair.smileImage));

            yield return new WaitForSeconds(displayDuration);
            yield return StartCoroutine(CrossFade(pair.smileImage, pair.originalImage));
        }
    }

    IEnumerator CrossFade(CanvasGroup from, CanvasGroup to)
    {
        to.gameObject.SetActive(true);

        float time = 0f;

        while (time < transitionDuration)
        {
            float t = time / transitionDuration;
            float smooth = Mathf.SmoothStep(0f, 1f, t);
            from.alpha = 1f - smooth;
            to.alpha = smooth;

            time += Time.deltaTime;
            yield return null;
        }

        from.alpha = 0f;
        from.gameObject.SetActive(false);

        to.alpha = 1f;
    }

}


