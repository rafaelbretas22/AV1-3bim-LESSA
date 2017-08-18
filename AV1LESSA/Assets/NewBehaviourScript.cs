using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Entry 
{
	public string key;
	public int value;

	public Entry (string k, int v)
	{
		key = k;
		value = v;
	}
}

public class NewBehaviourScript : MonoBehaviour {

	public List<Entry> lista = new List<Entry>();

	void Reset()
	{
		lista.Add (new Entry ("kilos", 0));
	}


}
