/*using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using MiscUtil.Collections.Extensions;
using Bolt;
using Ludiq;

public class ListSorter : MonoBehaviour
{
    public enum byVariable { byNameDescending, byLevelDescending }
    private List<GameObject> sortedList;

    public List<GameObject> SortListBy(byVariable By, List<GameObject> objectList)
    {
        if (By == byVariable.byNameDescending)
        {
            sortedList = objectList.OrderByDescending(o => o.name.Length).ToList();
        }
        if (By == byVariable.byLevelDescending)
        {
            sortedList = System.Array.Sort(objectList, delegate(GameObject skill1, GameObject skill2)
            {
                skill1.GetType();
            });
        }
        return sortedList;
    }

}*/

