﻿using System;
using StardewValley;
using Object = StardewValley.Object;

namespace ProducerFrameworkMod.Utils
{
    internal class ObjectUtils
    {
        public const char ObjectSeparator = '/';

        internal static bool IsObjectStringFromObjectName(string objectString, string objectName)
        {
            return objectString.StartsWith(objectName + ObjectSeparator);
        }

        internal static string GetObjectParameter(string objectString, int position)
        {
            return objectString.Split(ObjectSeparator)[position];
        }

        internal static string GetPreserveName(Object.PreserveType preserveType, string preserveParentName)
        {
            switch (preserveType)
            {
                case Object.PreserveType.Wine:
                    return $"{preserveParentName} Wine";
                case Object.PreserveType.Jelly:
                    return $"{preserveParentName} Jelly";
                case Object.PreserveType.Pickle:
                    return $"Pickled {preserveParentName}";
                case Object.PreserveType.Juice:
                    return $"{preserveParentName} Juice";
                case Object.PreserveType.Roe:
                    return $"{preserveParentName} Roe";
                case Object.PreserveType.AgedRoe:
                    return $"Aged {preserveParentName}";
            }
            return null;
        }

        internal static string GetCategoryName(int categoryIndex)
        {
            switch (categoryIndex)
            {
                case -6:
                    return Game1.content.LoadString("Strings\\StringsFromCSFiles:CraftingRecipe.cs.573");
                case -5:
                    return Game1.content.LoadString("Strings\\StringsFromCSFiles:CraftingRecipe.cs.572");
                case -4:
                    return Game1.content.LoadString("Strings\\StringsFromCSFiles:CraftingRecipe.cs.571");
                case -3:
                    return Game1.content.LoadString("Strings\\StringsFromCSFiles:CraftingRecipe.cs.570");
                case -2:
                    return Game1.content.LoadString("Strings\\StringsFromCSFiles:CraftingRecipe.cs.569");
                case -1:
                    return Game1.content.LoadString("Strings\\StringsFromCSFiles:CraftingRecipe.cs.568");
                case -27:
                    return DataLoader.Helper.Translation.Get("Object.Category.TappedTreeProduct");
                case -14:
                    return DataLoader.Helper.Translation.Get("Object.Category.Meat");
                case -16:
                    return DataLoader.Helper.Translation.Get("Object.Category.BuildingResources");
                case -15:
                    return DataLoader.Helper.Translation.Get("Object.Category.MetalResources");
                case -777:
                    return Game1.content.LoadString("Strings\\StringsFromCSFiles:CraftingRecipe.cs.574");
                default:
                    var categoryDisplayName = Object.GetCategoryDisplayName(categoryIndex);
                    return  !string.IsNullOrEmpty(categoryDisplayName) ? categoryDisplayName : "???" ;
            }
        }
    }

    internal enum ObjectParameter
    {
        Name = 0,
        Price = 1,
        DisplayName = 4
    }
}
