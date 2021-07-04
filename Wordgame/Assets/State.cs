using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName ="State")]
public class State : ScriptableObject
{
    [TextArea(10,14)] [SerializeField] string Storytext;
    [SerializeField] State[] nextState;

    public string GetStateStory()
    {
        return Storytext;
    }
    public State[] GetNextState()
    {
        return nextState;
    }
}
