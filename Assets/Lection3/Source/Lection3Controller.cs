
using System.Collections.Generic;
using UnityEngine;

public class Lection3Controller : MonoBehaviour
{
    [SerializeField] private string _value;
     private List<string> _list  = new List<string>();
    
    
    [ContextMenu("Print")]

    private void Print()
    {
        string msg = "list:";
        for (int i = 0; i < _list.Count; ++i)
            msg += $"\n{_list[i]}";
        Debug.Log(msg);
    }
    
    
    
    [ContextMenu("Add")]

    private void Add()
    {
        Debug.Log("Add: " + _value);
        _list.Add(_value);
    }
    
    
    
    [ContextMenu("Remove")]

    private void Remove()
    {
        Debug.Log("Remove: " + _value);
        _list.Remove(_value);
    }
    
    
    
    [ContextMenu("Clear")]

    private void Clear()
    {
        Debug.Log("Clear");
        _list.Clear();
    }
    
    
    
    [ContextMenu("Sort")]

    private void Sort()
    {
        Debug.Log("Sort");
        _list.Sort();
    }

}
