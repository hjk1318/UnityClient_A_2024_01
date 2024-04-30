using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using System.Text;

#if UNITY_EDITOR

public class GameSystemEditor : Editor
{
    public override void OnInspectorGUI()
    {
        base.OnInspectorGUI();

        GameSystem gameSystem = (GameSystem)target;

        if (GUILayout.Button("Reset Story Models"))
        {
            gameSystem.ResetStoryModels();
        }
    }

    public StoryModel[] storymodels;

#endif
}

    public class GameSystem : MonoBehaviour
    {
        public StoryModel[] storyModels;
#if UNITY_EDITOR

        [ContextMenu("Reset Story Models")]
        public void ResetStoryModels()
        {
            storyModels = Resources.LoadAll<StoryModel>(""); //Resources 폴더 아래 모든 모델 불러오기
        }
#endif
    }

