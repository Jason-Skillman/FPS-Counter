using UnityEditor;
using UnityEngine;
using UnityEngine.EventSystems;

public static class FPSCounterEditor {
	
	[MenuItem("GameObject/FPS/FPS Counter", false, 10)]
	static void CreateCustomPrimitiveGameObject(MenuCommand menuCommand) {
		//Check if the console has already been created
		FPSCounter counter = Object.FindObjectOfType<FPSCounter>();

		if(counter != null) {
			Debug.LogWarning("FPS counter has already been created.");
			Selection.activeObject = counter;
			return;
		}

		//Use the asset database to fetch the console prefab
		GameObject consolePrefab = AssetDatabase.LoadAssetAtPath<GameObject>("Packages/com.jasonskillman.fpscounter/Runtime/Prefabs/FPSCounter.prefab");

		//Instantiate the prefab in the hierarchy
		PrefabUtility.InstantiatePrefab(consolePrefab);

		Selection.activeObject = consolePrefab;
	}
	
}