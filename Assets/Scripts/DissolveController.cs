using Unity.Mathematics;
using UnityEngine;

public class DissolveController : MonoBehaviour{

    // [Range(0,1)]
    // [SerializeField] private float _cutOff = 0.5f;

    [SerializeField] private Renderer _renderer;
    [SerializeField] private float _dissolveSpeed = 3f;
    private float _dissolveAmount = 1;
    private bool _dissolving;

    private void Update() {
        // _renderer.material.SetFloat("_Cutoff", _cutOff);
        if(Input.GetKeyDown(KeyCode.D)){
            _dissolving = !_dissolving;
        }

        if(_dissolving){
            _dissolveAmount = Mathf.MoveTowards(_dissolveAmount, 0f, _dissolveSpeed * Time.deltaTime);
        }else{
            _dissolveAmount = Mathf.MoveTowards(_dissolveAmount, 1f, _dissolveSpeed * Time.deltaTime);
        }

        _renderer.material.SetFloat("_Cutoff", _dissolveAmount);
    }
}