using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
[ExecuteInEditMode]

public class GridCube : MonoBehaviour
{
    private TMP_Text label;
    [SerializeField][Range(1, 20)] int gridSize = 10; // 0 - 0 10 - 1 20 - 2 30 - 3

    // 0.4 /10 = 0.04 --> 0+10 -->0
    // 5.5 / 10 = 0.55 --> 1 --> 10
    // 24.5 / 10=2.45 --> 2+10 --> 20
    private void Start()
    {
        label = GetComponentInChildren<TMP_Text>();
    }

    private void Update()
    { // ����������� ���������� ��� ������� ����� ����� � ��������� unity
        int girdX = Mathf.RoundToInt(transform.position.x / gridSize);
        int gridY = Mathf.RoundToInt(transform.position.z / gridSize); 

        int unityX = girdX * gridSize;
        int unityY = gridY * gridSize;

        transform.position = new Vector3(unityX, 0, unityY);
        string labelText = girdX + "," + gridY ; // ��������� ������ �� ��������� ����� ����� �� � � �� ��������� �
        label.text = labelText; // ����������� ���� ������ ���������� ����� ��������
        name = labelText;// ����������� ����� ������� ����� ��������
    }


}

