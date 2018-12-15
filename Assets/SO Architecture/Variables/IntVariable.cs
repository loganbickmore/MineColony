﻿using DanielEverland.ScriptableObjectArchitecture.Utility;
using UnityEngine;

namespace DanielEverland.ScriptableObjectArchitecture.Variables
{
    [CreateAssetMenu(
    fileName = "IntVariable.asset",
    menuName = SOArchitecture_Utility.VARIABLE_SUBMENU + "int",
    order = SOArchitecture_Utility.ASSET_MENU_ORDER_COLLECTIONS + 4)]
    public class IntVariable : BaseVariable<int>
    {
    }
}