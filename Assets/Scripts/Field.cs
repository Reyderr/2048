using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Field : MonoBehaviour
{
    public float cellSize;
    public float spacing;
    public int fieldSize;

    [SerializeField]
    private Cell _cellPref;
    [SerializeField]
    private RectTransform rt;

    private Cell[,] _field;


    void Start()
    {
        generateStartField();
    }

    private void fieldCreate()
    {
        _field = new Cell[fieldSize, fieldSize];

        float fieldWidth = fieldSize * (cellSize + spacing) + spacing;
        rt.sizeDelta = new Vector2(fieldWidth, fieldWidth);

        float startX = -(fieldWidth / 2) + (cellSize / 2) + spacing;
        float startY = (fieldWidth / 2) - (cellSize / 2) - spacing;

        for (int x = 0; x < fieldSize; x++)
        {
            for(int y = 0; y < fieldSize; y++)
            {
                var cell = Instantiate(_cellPref, transform, false);
                var pos = new Vector2(startX + (x * (cellSize + spacing)), startY - (y * (cellSize + spacing)));
                cell.transform.localPosition = pos;
                _field[x, y] = cell;
                cell.SetValue(x, y, 0);
            }
        }
    }

    public void generateStartField()
    {
        if (_field == null)
            fieldCreate();

        for (int x = 0; x < fieldSize; x++)
            for (int y = 0; y < fieldSize; y++)
                _field[x, y].SetValue(x, y, 0);

    }

}
