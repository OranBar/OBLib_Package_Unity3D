using System;
using System.Linq;
using System.Collections.Generic;
using UnityEngine;

/* *****************************************************************************
 * File:    UnityMathExtensions.cs
 * Author:  Philip Pierce - Friday, September 26, 2014
 * Description:
 *  Unity extensions for math
 *  
 * History:
 *  Friday, September 26, 2014 - Created
 * ****************************************************************************/

/// <summary>
/// Unity extensions for math
/// </summary>
public static class UnityMathExtensions
{
    #region DistanceTo

    /// <summary>
    /// Returns the Vector3 distance between these two GameObjects
    /// </summary>
    /// <param name="go"></param>
    /// <param name="otherGO"></param>
    /// <returns></returns>
    public static float DistanceTo(this GameObject go, GameObject otherGO)
    {
        return Vector3.Distance(go.transform.position, otherGO.transform.position);
    }

    /// <summary>
    /// Returns the Vector3 distance between these two points
    /// </summary>
    /// <param name="go"></param>
    /// <param name="pos"></param>
    /// <returns></returns>
    public static float DistanceTo(this GameObject go, Vector3 pos)
    {
        return Vector3.Distance(go.transform.position, pos);
    }

    /// <summary>
    /// Returns the Vector3 distance between these two points
    /// </summary>
    /// <param name="start"></param>
    /// <param name="dest"></param>
    /// <returns></returns>
    public static float DistanceTo(this Vector3 start, Vector3 dest)
    {
        return Vector3.Distance(start, dest);
    }

    /// <summary>
    /// Returns the Vector3 distance between these two transforms
    /// </summary>
    /// <param name="start"></param>
    /// <param name="dest"></param>
    /// <remarks>
    /// Suggested by: Vipsu
    /// Link: http://forum.unity3d.com/members/vipsu.138664/
    /// </remarks>
    public static float DistanceTo(this Transform start, Transform dest)
    {
        return Vector3.Distance(start.position, dest.position);
    }

	public static float DistanceTo(this Transform start, Vector3 dest) {
		return Vector3.Distance(start.position, dest);
	}

    // DistanceTo
    #endregion

}