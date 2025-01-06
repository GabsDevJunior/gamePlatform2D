using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class ItemCollectable : itemCollectableBase
{
    protected override void OnCollect()
    {
        base.OnCollect();
        itemManager.Instance.addCoins();
    }
}
