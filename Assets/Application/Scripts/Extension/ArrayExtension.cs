using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class ArrayExtension
{
    /// <summary>
    /// 指定された配列の中からランダムに要素を返します
    /// </summary>
    public static T Random<T>(params T[] values)
    {
        return values[UnityEngine.Random.Range(0, values.Length)];
    }
}
