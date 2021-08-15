using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class awakeItemEnabler : MonoBehaviour
{
    [SerializeField]
    public GameObject[] toEnable;

    private void Awake()
    {
        foreach(GameObject gameObject in toEnable)
        {
            gameObject.SetActive(true);
        }
    }
}
