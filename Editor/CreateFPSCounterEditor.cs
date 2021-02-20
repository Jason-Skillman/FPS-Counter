using UnityEditor;
using UnityEngine;
using UnityEngine.EventSystems;

namespace FPS {
	public static class CreateFPSCounterEditor {

		[MenuItem("GameObject/FPS/FPS Counter", false, 10)]
		static void CreateFPSCounter(MenuCommand menuCommand) {
			//Check if the object has already been created
			FPSCounter counter = Object.FindObjectOfType<FPSCounter>();

			if(counter != null) {
				Debug.LogWarning("FPS Counter has already been created.");
				Selection.activeObject = counter;
				return;
			}

			//Use the asset database to fetch the prefab
			GameObject objectPrefab = AssetDatabase.LoadAssetAtPath<GameObject>(
				"Packages/com.jasonskillman.fpscounter/Runtime/Prefabs/FPSCounter.prefab");

			//Instantiate the prefab in the hierarchy
			PrefabUtility.InstantiatePrefab(objectPrefab);

			Selection.activeObject = objectPrefab;
		}

	}
}
