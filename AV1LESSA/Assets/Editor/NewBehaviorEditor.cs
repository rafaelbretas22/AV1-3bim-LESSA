using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(NewBehaviourScript))]
public class NewBehaviorEditor : Editor {


	 public override void OnInspectorGUI(){
	
		NewBehaviourScript Behaviour = target as NewBehaviourScript;

		foreach(Entry e in Behaviour.lista){
			
			e.value = EditorGUILayout.IntField (e.key, e.value );
			
		
		}
	}
}
