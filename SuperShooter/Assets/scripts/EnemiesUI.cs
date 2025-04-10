
    using TMPro;
    using UnityEngine;

    public class EnemiesUI : MonoBehaviour
    {
        TMP_Text text;

        void Start()
        {
            text = GetComponent<TMP_Text>();
            EnemiesManager.instance.onChanged.AddListener(RefreshText);
        }

        void RefreshText()
        {
            text.text = "Remaining Enemies: " + EnemiesManager.instance.enemies.Count;
        }
    }

