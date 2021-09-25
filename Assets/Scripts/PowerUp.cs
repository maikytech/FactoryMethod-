using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class PowerUp : MonoBehaviour
{
    // _ private
    [SerializeField] private string _id;

    //Get
    //public = capital letters
    public string Id => _id;

}
