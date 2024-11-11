using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;  

public class EnemyManager : MonoBehaviour
{
    public Enemy enemyData;  // 엑셀 데이터가 들어있는 ScriptableObject
    public List<Image> enemyImages; // 여러 적 스프라이트를 표시할 UI Image 리스트
    public List<TextMeshProUGUI> enemyInfoTexts;  // 여러 적 정보를 표시할 UI Text 리스트

    void Start()
    {
        // 여러 적에 대해 정보를 처리
        SetEnemyInfo("scarecrow", 0);  // 첫 번째 UI 요소에 허수아비 정보 표시
        SetEnemyInfo("devil", 1);       // 두 번째 UI 요소에 악마 정보 표시
    }

    // 적의 정보와 이미지를 설정하는 함수
    private void SetEnemyInfo(string enemy_name, int index)
    {
        EnemyTest scarecrowData = GetEnemyData("scarecrow");

        if (scarecrowData != null)
        {
            // 적 이미지 설정
            enemyImages[index].sprite = Resources.Load<Sprite>("Sprites/" + "scarecrow");

            // 적 정보 텍스트 설정
            enemyInfoTexts[index].text = "enemy_name: " + scarecrowData.enemy_name + "\n" +
                                         "HP: " + scarecrowData.HP + "\n" +
                                         "attack: " + scarecrowData.attack + "\n" +
                                         "speed: " + scarecrowData.speed + "\n" +
                                         "defense: " + scarecrowData.defense + "\n" +
                                         "stiffness_resistance: " + scarecrowData.stiffness_resistance;
        }
        else
        {
            Debug.LogError("scarecrow" + " 데이터를 찾을 수 없습니다.");
        }
    }

    private void devilEnemyInfo(string enemy_name, int index)
    {
        EnemyTest devilData = GetEnemyData("devil");

        if (devilData != null)
        {
            // 적 이미지 설정
            enemyImages[index].sprite = Resources.Load<Sprite>("Sprites/" + "devil");

            // 적 정보 텍스트 설정
            enemyInfoTexts[index].text = "enemy_name: " + devilData.enemy_name + "\n" +
                                         "HP: " + devilData.HP + "\n" +
                                         "attack: " + devilData.attack + "\n" +
                                         "speed: " + devilData.speed + "\n" +
                                         "defense: " + devilData.defense + "\n" +
                                         "stiffness_resistance: " + devilData.stiffness_resistance;
        }
        else
        {
            Debug.LogError("devil" + " 데이터를 찾을 수 없습니다.");
        }
    }

    // 엑셀에서 적 데이터를 가져오는 함수
    private EnemyTest GetEnemyData(string enemyName)
    {
        foreach (var enemy in enemyData.EnemyStats)
        {
            if (enemy.enemy_name == enemyName)
            {
                return enemy;
            }
        }
        return null;  // 찾지 못한 경우 null 반환
    }
}






//적 중에 한마리만 시트에 있는 정보를 적용시켜보고 데미지가 들어가는지 확인 
// 시트를 적용시키려면 캐릭터 변수를 만들고, 그 캐릭터를 ㄱ끌러다 놓고..기본 정보가 저장 되게...
