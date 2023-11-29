using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public enum ItemGradeType
{
    Nomal,
    Magic,
    Rare,
    Epic,
    Legend,
    God,
}

public enum ItemType
{
    Weapon,
    Armor,
    Boot,
    Expendables
}

public class ItemData
{
    public int enchan = 0;
    public int level = 0;
    public ItemGradeType grade = ItemGradeType.Nomal;
    public ItemType type;

    public Sprite icon;
}

public class ItemControl : MonoBehaviour
{

    [SerializeField] private item item;
    [SerializeField] private Transform parent;
    [SerializeField] private StateView sv;

    public Sprite[] waponSprites;
    public Sprite[] armorSprites;
    public Sprite[] bootSprites;
    public Sprite[] ExpendablesSprites;

   public  Dictionary<ItemType, List<Sprite>> dicSprite = new Dictionary<ItemType, List<Sprite>>();

    public Sprite[] frame;

    List<item> items = new List<item>();
    int invenCnt = 20;
    int invenMaxCnt = 0;

    int createIndex = 0;
    // Start is called before the first frame update
    void Start()
    {
        dicSprite.Add(ItemType.Weapon, waponSprites.ToList());
        dicSprite.Add(ItemType.Armor, armorSprites.ToList());
        dicSprite.Add(ItemType.Boot, bootSprites.ToList());
        dicSprite.Add(ItemType.Expendables, ExpendablesSprites.ToList());

        AddInventory(invenCnt);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F1))
        {

            //if (createIndex >= invenMaxCnt)
            //{
            //    return;
            //}
            bool isCreat = true;

            ItemData d = new ItemData();
            d.type = (ItemType)Random.Range((int)ItemType.Weapon, (int)ItemType.Expendables + 1);
            d.icon = dicSprite[d.type][Random.Range(0, dicSprite[d.type].Count)];

            if (d.type != ItemType.Expendables)
            {
                d.enchan = Random.Range(0, 10);
                d.level = Random.Range(0, 10) * 10;
                d.grade = (ItemGradeType)Random.Range((int)ItemGradeType.Nomal, (int)ItemGradeType.God + 1);
            }
            else
            {
                d.enchan = 0;
                d.level = 0;
                d.grade = ItemGradeType.Nomal;

                int findIndex = -1;

                for (int i = 0; i < items.Count; i++)
                {
                    if (items[i].icon.sprite == d.icon)
                    {
                        isCreat = false;
                        findIndex = i;
                        break;
                    }
                }

                if (!isCreat)
                {
                    items[findIndex].Count++;
                }
            }

            if (isCreat)
            {
                items[createIndex].SetData(d, this);
                item.SetStateView(sv);
                items[createIndex].icon.sprite = d.icon;
                createIndex++;
            }

        }

        if (Input.GetKeyDown(KeyCode.F2))
        {
            AddInventory(invenCnt);
        }
    }

    void AddInventory(int count)
    {
        for (int i = 0; i < count; i++)
        {
            item it = Instantiate(item, parent);
            it.Empty();
            items.Add(it);
        }
    }
}
