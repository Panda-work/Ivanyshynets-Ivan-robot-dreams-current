
using System.Collections.Generic;
using UnityEngine;

public class Lection3Controller : MonoBehaviour
{
    [SerializeField] private string _value;
     private List<string> _List;
    
    
    [ContextMenu("Print")]

    private void Print()
    {
        string msg = "list:";
        for (int i = 0; i < _List.Count; ++i)
            msg += $"\n{_List[i]}";
        Debug.Log(msg);
    }
    
    
    
    [ContextMenu("Add")]

    private void Add()
    {
        Debug.Log("Add: " + _value);
        _List.Add(_value);
    }
    
    
    
    [ContextMenu("Remove")]

    private void Remove()
    {
        Debug.Log("Remove: " + _value);
        _List.Remove(_value);
    }
    
    
    
    [ContextMenu("Clear")]

    private void Clear()
    {
        Debug.Log("Clear");
        _List.Clear();
    }
    
    
    
    [ContextMenu("Sort")]

    private void Sort()
    {
        Debug.Log("Sort");
        _List.Sort();
    }

}
