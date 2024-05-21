using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class StorySystem : MonoBehaviour
{
    public static StorySystem instance;
    public StoryModel currentStoryModel;

    public enum TEXTSYSTEM
    {
        NONE,
        DOING,
        SELECT,
        DONE
    }

    public float delay = 0.1f;
    public string fullText;
    private string currentText = "";
    public Text textComponent;
    public Text StoryIndex;
    public Image imageComponent;

    public Button[] buttonWay = new Button[3];
    public Text[] buttonWayText = new Text[3];

    public TEXTSYSTEM currentTextShow = TEXTSYSTEM.NONE;

    private void Awake()
    {
        instance = this;
    }


    // Start is called before the first frame update
    void Start()
    {
        for(int i = 0; i < buttonWay.Length; i++)
        {
            int wayIndex = i;
            buttonWay[i].onClick.AddListener(() => OnWayClick(wayIndex));
        }

        CoshowText();
    }
        
    public void StoryModelinit()
    {

        fullText = currentStoryModel.storyText;
        StoryIndex.text = currentStoryModel.storyNumber.ToString();

        for (int i = 0; i< currentStoryModel.option.Length; i++)
        {
            buttonWayText[i].text = currentStoryModel.option[i].buttonText;
        }
    }


    public void OnWayClick(int index)
    {
        if (currentTextShow == TEXTSYSTEM.DOING)
            return;

        bool CheckEventTypeNone = false;
        StoryModel playStoryModel = currentStoryModel;

        if(playStoryModel.option[index]. eventCheck.eventType == StoryModel.EventCheck.EventType.NONE)
        {
            for(int i = 0; i < playStoryModel.option[index].eventCheck.suceessResult.Length;i++)
            {
                GameSystem.instance.ApplyChoice(currentStoryModel.option[index].eventCheck.suceessResult[i]);
                CheckEventTypeNone = true;
            }
        }
    }

    public void CoshowText()
    {
        StoryModelinit();
        ResetShow();
        StartCoroutine(ShowText());
    }

    public void ResetShow()
    {
        textComponent.text = "";
        
        for(int i = 0; i < buttonWay.Length; i++)
        {
            buttonWay[i].gameObject.SetActive(false);
        }
    }
    IEnumerator ShowText()
    {
        currentTextShow = TEXTSYSTEM.DOING;

        if (currentStoryModel.MainImage != null)
        {
            Rect rect = new Rect(0, 0, currentStoryModel.MainImage.width, currentStoryModel.MainImage.height);
            Vector2 pivot = new Vector2(0.5f, 0.5f);
            Sprite sprite = Sprite.Create(currentStoryModel.MainImage,rect, pivot);

            imageComponent.sprite = sprite; ;
        }
        else
        {
            Debug.LogError("텍스쳐 로딩이 되지 않습니다. : " + currentStoryModel.MainImage.name);
        }

        for(int i= 0; i < fullText.Length; i++)
        {
            currentText = fullText.Substring(0, i);
            textComponent.text = currentText;
            yield return new WaitForSeconds(delay);
        }

        for (int i = 0; i < currentStoryModel . option.Length; i++)
        {
            buttonWay[i].gameObject.SetActive(true);
            yield return new WaitForSeconds(delay);
        }

        yield return new WaitForSeconds(delay);

        currentTextShow = TEXTSYSTEM.NONE;
    }
}
