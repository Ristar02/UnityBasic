using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;


public enum Rarity { TwoStar, ThreeStar, FourStar } //enum은 열거형으로, 특정 값의 집합을 정의합니다. 여기서는 캐릭터의 희귀도를 나타냅니다.

[System.Serializable]
public class CharacterInfo
{
    public string name;
    public Sprite twoStarImage;
    public Sprite threeStarImage;
    public Sprite fourStarImage;
}

public class GachaManager : MonoBehaviour
{
    public List<CharacterInfo> characterDatabase; // CharacterInfo라는 클래스의 타입의 리스트를 생성합니다.
    public Image displayImagePrefab;  // 결과 표시할 Image UI 프리팹
    public Transform canvasParent;

    private int[] tenPullResultsIndices; // 10연차 뽑기 결과를 저장할 인덱스 배열

    public void OnePull()
    {
        Rarity rarity;
        var result = GetRandomCharacter(out rarity); // 캐릭터와 희귀도 둘 다 받아옴
        ShowPullImage(result, rarity); // 희귀도 정보도 함께 전달
    }

    private List<(CharacterInfo character, Rarity rarity)> tenPullResults; // 튜플 리스트로 저장

    public void TenPull()
    {
        tenPullResults = new List<(CharacterInfo, Rarity)>();

        for (int i = 0; i < 10; i++)
        {
            Rarity rarity;
            var character = GetRandomCharacter(out rarity);
            tenPullResults.Add((character, rarity));
        }

        ShowTenPullImages();
    }

    CharacterInfo GetRandomCharacter(out Rarity rarity)
    {
        int randomValue = Random.Range(1, 101);

        if (randomValue <= 10) rarity = Rarity.FourStar;
        else if (randomValue <= 40) rarity = Rarity.ThreeStar;
        else rarity = Rarity.TwoStar;

        return characterDatabase[Random.Range(0, characterDatabase.Count)];
    }

    void ShowPullImage(CharacterInfo info, Rarity rarity)
    {
        var img = Instantiate(displayImagePrefab, canvasParent);
        img.sprite = GetSpriteByRarity(info, rarity);
        img.GetComponent<Button>().onClick.AddListener(() => Destroy(img.gameObject));
    }

    void ShowTenPullImages()
    {
        foreach (var result in tenPullResults) // var result는 튜플로, character와 rarity를 포함합니다.
        {
            var img = Instantiate(displayImagePrefab, canvasParent); // var의 자료형은 image 타입이 됩니다.
            img.sprite = GetSpriteByRarity(result.character, result.rarity);
            img.GetComponent<Button>().onClick.AddListener(() => Destroy(img.gameObject));
        }
    }

    Sprite GetSpriteByRarity(CharacterInfo info, Rarity rarity)
    {
        switch (rarity)
        {
            case Rarity.FourStar: return info.fourStarImage;
            case Rarity.ThreeStar: return info.threeStarImage;
            default: return info.twoStarImage;
        }
    }
}
