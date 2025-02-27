﻿using UnityEngine;

namespace CodeSampleOne
{
    public class AppManager : MonoBehaviour
    {
        [Header("Views")]
        [Space(10)]
        [SerializeField]
        private HomeView homeView = default;

        [Header("Rect Transforms")]
        [Space(10)]
        [SerializeField]
        private RectTransform modalParent = default;

        // For the sake of simplicity, I'm placing the prefabs here for this example.
        [Header("Prefabs")]
        [Space(10)]
        [SerializeField]
        private AnimalRow animalRowPrefab = default;
        [SerializeField]
        private AnimalCard animalCardPrefab = default;
        [SerializeField]
        private InfoModalTemplate infoModalTemplatePrefab = default;

        public AnimalRow AnimalRowPrefab { get { return animalRowPrefab; } }
        public AnimalCard AnimalCardPrefab { get { return animalCardPrefab; } }
        public InfoModalTemplate InfoModalTemplatePrefab { get { return infoModalTemplatePrefab; } }
        public RectTransform ModalParent { get { return modalParent; } }

        public DataManager DataManager { get; private set; }
        //Global Static Variable
        public static AppManager Instance { get; private set; }

        // App starts here. My "main" function for this sample.
        void Start()
        {
            Instance = this;
            // Set up DataManager object.
            DataManager = new DataManager();
            DataManager.Initialize();

            //Setup the home view
            homeView.Setup();
        }
    }
}