using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System.Collections;

public class ButtonSpriteChange : MonoBehaviour
{
    public static ButtonSpriteChange buttonSpriteChange;  
    public Sprite originalButtonBackground;
    public Sprite errorButtonBackground;
    public Color originalTextColor = Color.black;
    public Color errorTextColor = Color.white;

    public float shakeAmount = 7f;
    public float shakeDuration = 0.5f; 
    
    public void ChangeButtonBackground(Button button)
    {
        StartCoroutine(ChangeButtonBackgroundCoroutine(button));
    }

    private IEnumerator ChangeButtonBackgroundCoroutine(Button button)
    {
        
        Image buttonImage = button.GetComponent<Image>();
        
        TextMeshProUGUI buttonText = button.GetComponentInChildren<TextMeshProUGUI>();

        if (buttonImage != null && buttonText != null)
        {
            buttonImage.sprite = errorButtonBackground;
            buttonText.color = errorTextColor;
            
            StartCoroutine(ShakeButton(button.transform));
            
            yield return new WaitForSeconds(shakeDuration);
            buttonImage.sprite = originalButtonBackground;
            buttonText.color = originalTextColor;
        }
        else
        {
            Debug.LogError("Button does not have necessary components (Image/TextMeshProUGUI)!");
        }
    }

    private IEnumerator ShakeButton(Transform buttonTransform)
    {
        Vector3 originalPosition = buttonTransform.position;
        
        float elapsedTime = 0f;
        while (elapsedTime < shakeDuration)
        {
            float xOffset = Random.Range(-shakeAmount, shakeAmount);
            buttonTransform.position = originalPosition + new Vector3(xOffset, 0, 0);

            elapsedTime += Time.deltaTime;
            yield return null; 
        }
        buttonTransform.position = originalPosition;
    }
    
    private void Awake()
    {
        if (buttonSpriteChange == null)
        {
            buttonSpriteChange = this;  
        }
        else
        {
            Destroy(gameObject);
        }
    }
}
