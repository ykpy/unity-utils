using UnityEngine;

public class SingletonMonobehaviour<T> : MonoBehaviour where T : MonoBehaviour {

	static T instance;
	public static T Instance {
		get {
			return instance ?? (instance = FindObjectOfType<T>());
		}
	}

	protected virtual void Awake() {
		if (instance == null) {
			instance = FindObjectOfType<T>();
		} else if (instance != this) {
			Destroy(this);
		}
	}

	protected bool IsExistsInstance() {
		return FindObjectOfType<T>() != null;
	}

}
