using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static STORYGAME.StoryTableObject;

[CreateAssetMenu(fileName = "NewStory", menuName = "ScriptavleObject/StoryTableObject")]

public class StoryModel : MonoBehaviour
{
    public int storyNumber;
    public Texture2D mainImage;

    public enum STORYTYPE
    {
        MAIN,
        SUB,
        SERIAL
    }

    public STORYTYPE storygame;
    public bool storytype;

    [TextArea(10, 10)]
    public string storyText;

    public Option[] option;

    [System.Serializable]
    public class Option
    {
        public string optionText;
        public string buttonText;
        public EventCheck eventCheck;
    }

    [System.Serializable]
    public class EventCheck
    {
        public int checkValue;
        public enum EventType : int
        {
            NONE,
            GoToBattle,
            CheckSTR,
            CheckDEX,
            CheckCON,
            CheckINT,
            CheckWIS,
            CheckCHA
        }

        public EventType eventType;

        public Result[] suceessResult;
        public Result[] failResult;
    }


    [System.Serializable]
    public class Result
    {
        public enum ResultType : int
        {
            ChangeHp,
            ChangeSp,
            AddExperience,
            GoToShop,
            GoToNextStory,
            GoToRandomStory,
            GoToEnding
        }

        public ResultType resultType;
        public int value;
        public StateMachineBehaviour stats;

    }
}