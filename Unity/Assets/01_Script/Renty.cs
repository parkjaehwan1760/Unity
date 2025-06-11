using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Renty : MonoBehaviour
{
    [SerializeField] Image Img_BG;
    [SerializeField] Image[] Img_Character;
    [SerializeField] TextMeshProUGUI Text_name;
    [SerializeField] TextMeshProUGUI Text_job;
    [SerializeField] TextMeshProUGUI Text_Talk;
    [SerializeField] Button Btn_Next;

    int id = 1;

    void Start()
    {
        RefreshUI();
    }

    public void OnClickButton()
    {
        id++; // 2
        RefreshUI();
    }

    void RefreshUI()
    {
        int characterID = SData.GetDialogueData(id).Character; // ��� ���̺��� 1�� ID�� ĳ���� ID �÷��� ������ �´�.
        Text_name.text = SData.GetCharacterData(characterID).Name; // ĳ���� ���̺��� ĳ���� ID�� �ش��ϴ� �̸��� ������ �´�.
        Text_job.text = SData.GetCharacterData(characterID).Position; // ĳ���� ���̺��� ĳ���� ID�� Ÿ��Ʋ�� ������ �´�.

        Text_Talk.text = SData.GetDialogueData(id).Dialogue;
    }
}


