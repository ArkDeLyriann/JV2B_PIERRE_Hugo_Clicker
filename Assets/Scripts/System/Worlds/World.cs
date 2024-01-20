using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "World")]
public class World : ScriptableObject
{
    public List<GameObject> Ennemies;
    public string Name;
    public int Tag;

}
