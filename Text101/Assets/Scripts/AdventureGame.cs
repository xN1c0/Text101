﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AdventureGame : MonoBehaviour
{
    [SerializeField] Text textComponent;
    [SerializeField] State startingState;

    State state;

    // Start is called before the first frame update
    void Start()
    {
        state = startingState;
        Debug.Log(startingState);
        textComponent.text = state.GetStateStory();
    }

    // Update is called once per frame
    void Update()
    {
        ManageState();
    }

    private void ManageState()
    {
        State[] nextStates = state.GetNextStates();

        for(int i=0; i < nextStates.Length; i++)
            if(Input.GetKeyDown(KeyCode.Alpha1 + i))
                state = nextStates[i];

        textComponent.text = state.GetStateStory();
    }
}

