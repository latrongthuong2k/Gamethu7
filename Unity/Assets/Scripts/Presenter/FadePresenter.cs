using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading.Tasks;
[RequireComponent(typeof(FadeViews))]
[RequireComponent(typeof(FadeManager))]

public class FadePresenter : MonoBehaviour
{
    [SerializeField]
    private FadeManager _fadeManager;
    private FadeViews _fadeViews;
    
    private void Awake(){
        _fadeManager = GetComponent<FadeManager>();
        _fadeViews = GetComponent<FadeViews>();
    }
    public async Task SceneChange(string sceneName. bool isFirst = false)   
    {

    }
    public async Task FadeIn(CanvasGroup canvasGroup)   
    {
        await _fadeManager.FadeIn(canvasGroup);
    } 
    

     ///<sumary>
    ///</sumary> 
    public void FadeOut()
    {
        
    }
}
