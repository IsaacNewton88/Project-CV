using UnityEngine;

[CreateAssetMenu(fileName = "Item List", menuName = "Item List")]
public class ItemList : ScriptableObject
{
    public string _name;
    public bool isOwned = false;
    public Sprite icon;
}
