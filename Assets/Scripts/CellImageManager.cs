using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CellImageManager : MonoBehaviour
{
    public static CellImageManager Instance;
    public Color[] CellColors;
    public Color darkTheme;
    public Color lightTheme;

    private void Awake()
    {
        if (Instance == null)
            Instance = this;
    }
}
