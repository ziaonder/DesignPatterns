using System;
using System.Collections.Generic;

public class TreeFactory
{
    private static Dictionary<string, TreeType> treeTypes = new Dictionary<string, TreeType>();

    public static TreeType GetTreeType(string name, string color, string texture)
    {
        if (!treeTypes.ContainsKey(name))
        {
            treeTypes[name] = new TreeType(name, color, texture);
        }
        
        return treeTypes[name];
    }
}
