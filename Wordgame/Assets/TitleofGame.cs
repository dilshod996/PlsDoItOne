using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TitleofGame : MonoBehaviour
{
    [SerializeField] Text textComponent;
    [SerializeField] State StartingState;

    State state;



    // Start is called before the first frame update
    void Start()
    {
        state = StartingState;
        textComponent.text = state.GetStateStory();

    }

    // Update is called once per frame
    void Update()
    {

    }
}
