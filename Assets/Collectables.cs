using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectables : MonoBehaviour
{
    public string collectableName;
    public string description;
    public GameObject player;

    public abstract void Use();
}
