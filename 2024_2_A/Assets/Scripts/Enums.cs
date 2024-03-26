using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace STORYGAME
{
    public class Enums
    {
        public enum StoryType
        {
            MAIN,
            SUB,
            SERIAL
        }

        public enum EvenType
        {
            NONE,
            GoToBattle = 100,
            ChectSTR = 1000,
            CheckDEX,
            CheckCON,
            CheckINT,
            CheckWIS,
            CheckCHA
        }

        public enum ResultType
        {
            ChangeHp,
            ChangeSp,
            AddExperience,
            GoToShop,
            GoToNextStory,
            GoToRandeomStory,
            GoToEnding
        }

    }


    [System.Serializable]
    public class Stats
    {   //ü�� ���ŷ�
        public int hpPoint;
        public int spPoint;

        public int currentHpPoint;
        public int currentSpPoint;
        public int currentXpPoint;

        //�⺻����
        public int Strength;
        public int Dexterity;
        public int consitiution;
        public int Intelligence;
        public int Wisdom;
        public int charisma;
    }
}