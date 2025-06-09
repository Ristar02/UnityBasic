using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;


public enum Rarity { TwoStar, ThreeStar, FourStar } //enum�� ����������, Ư�� ���� ������ �����մϴ�. ���⼭�� ĳ������ ��͵��� ��Ÿ���ϴ�.

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
    public List<CharacterInfo> characterDatabase; // CharacterInfo��� Ŭ������ Ÿ���� ����Ʈ�� �����մϴ�.
    public Image displayImagePrefab;  // ��� ǥ���� Image UI ������
    public Transform canvasParent;

    private int[] tenPullResultsIndices; // 10���� �̱� ����� ������ �ε��� �迭

    public void OnePull()
    {
        Rarity rarity;
        var result = GetRandomCharacter(out rarity); // ĳ���Ϳ� ��͵� �� �� �޾ƿ�
        ShowPullImage(result, rarity); // ��͵� ������ �Բ� ����
    }

    private List<(CharacterInfo character, Rarity rarity)> tenPullResults; // Ʃ�� ����Ʈ�� ����

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
        foreach (var result in tenPullResults) // var result�� Ʃ�÷�, character�� rarity�� �����մϴ�.
        {
            var img = Instantiate(displayImagePrefab, canvasParent); // var�� �ڷ����� image Ÿ���� �˴ϴ�.
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
