using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IColorBlind
{
    event System.Action<int> OnShadesChanged;
    void ChangeShades(int shadeIndex);
	
}
