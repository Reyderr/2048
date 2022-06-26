using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Cell : MonoBehaviour
{
    public int Y { get; private set; }
    public int X { get; private set; }
    public int value { get; private set; }
    public int points => isEmpty ? 0 : (int)Mathf.Pow(2, value);
    public bool isEmpty => value == 0;
    public const int maxRes = 11;

    [SerializeField]
    private Image _image;
    [SerializeField]
    private TextMeshProUGUI _pointsText;

    public void SetValue( int y, int x, int value)
    {
        Y = y;
        X = x;
        this.value = value;

        UpdateCell();
    }

    public void UpdateCell()
    {
        _pointsText.text = isEmpty ? string.Empty : points.ToString();
        _pointsText.color = value <= 2 ? CellImageManager.Instance.darkTheme : 
            CellImageManager.Instance.lightTheme;
        _image.color = CellImageManager.Instance.CellColors[value];
    }
}
