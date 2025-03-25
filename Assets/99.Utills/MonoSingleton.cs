using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Singleton 을 쉽게 만들기 위한 Utill
/// 상속만 받으면 싱글톤 완성
/// </summary>


public class MonoSingleton<T> : MonoBehaviour where T : MonoBehaviour
{
    protected static T instance;
    public static T Instance => instance;    
    

    [SerializeField] // 씬에서 지워져야 하는지 ?
    protected bool isDontDestroyOnLoad = false;

    protected virtual void Awake()
    {
        if(instance == null)
        {
            instance = this.gameObject.GetComponent<T>();
            if(isDontDestroyOnLoad)
            {
                DontDestroyOnLoad(instance);
            }
        }
        else
        {
            Debug.LogWarning($"Singleton {this.name} 은 중복 생성시도 되었습니다.");
            Destroy(this.gameObject);
        }
    }

    protected virtual void OnDestroy()
    {
        if(instance != null)
            instance = null;
    }
}
