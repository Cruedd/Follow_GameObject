using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Follow_GameObject : MonoBehaviour
{
    [SerializeField] private Transform FolowedObject;
    [SerializeField] private Transform Object;
    [SerializeField] private float distanceBelowPlayerY;
    [SerializeField] private float distanceBelowPlayerZ;
    [SerializeField] private float distanceBelowPlayerX;

    void Update()
    {
        Object.position = FolowedObject.position + -FolowedObject.up * distanceBelowPlayerY + distanceBelowPlayerZ * FolowedObject.forward + FolowedObject.right * distanceBelowPlayerX;


    }
}
