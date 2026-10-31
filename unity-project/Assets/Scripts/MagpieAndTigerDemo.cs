using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace MagpieAndTiger
{
    /// <summary>
    /// Small, scene-friendly prototype controller for the Magpie & Tiger demo.
    /// Drop this component on an empty GameObject in a 2D scene.
    /// </summary>
    public sealed class MagpieAndTigerDemo : MonoBehaviour
    {
        [Header("Demo state")]
        [SerializeField] private int shardGoal = 3;
        [SerializeField] private Text statusLabel;
        [SerializeField] private Text dialogueLabel;

        private readonly HashSet<int> collected = new();
        private bool finished;

        public int CollectedCount => collected.Count;
        public bool IsFinished => finished;

        private void Start()
        {
            UpdateStatus();
            ShowDialogue("까치의 안내를 따라 마을에 흩어진 색 조각을 찾아보세요.");
        }

        public void CollectShard(int shardId)
        {
            if (finished || !collected.Add(shardId)) return;
            UpdateStatus();
            ShowDialogue("색 조각을 찾았습니다. 민화의 색은 장면의 마음을 보여줍니다.");
            if (collected.Count >= shardGoal)
            {
                finished = true;
                ShowDialogue("호랑이: 이제 그림의 색이 돌아왔구나. 까치도 네 용기를 기억할 거야!");
            }
        }

        public void TalkToTiger()
        {
            ShowDialogue(finished
                ? "호랑이: 잘했어. 이제 너만의 민화를 완성해 보렴."
                : "호랑이: 색 조각 세 개를 찾아오면 민화의 비밀을 알려주지.");
        }

        private void UpdateStatus()
        {
            if (statusLabel != null) statusLabel.text = $"색 조각 {collected.Count} / {shardGoal}";
        }

        private void ShowDialogue(string message)
        {
            if (dialogueLabel != null) dialogueLabel.text = message;
        }
    }
}
