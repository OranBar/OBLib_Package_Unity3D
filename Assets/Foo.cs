using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// using BarbarO.ExtensionMethods;

public class Foo : MonoBehaviour
{
	public int myInt = 5;
	void EditorUpdate()
    {
		myInt = 5;
		this.gameObject.AddOrGetComponent<BoxCollider>();
	}

    // Update is called once per frame
    void Update()
    {
        
    }
}
