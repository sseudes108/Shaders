using UnityEngine;

public class DissolveController : MonoBehaviour{

    [SerializeField] private Renderer _renderer;
    [SerializeField] private float _dissolveSpeed = 1f;

    [SerializeField] private GameObject _effect;
    private float _dissolveAmount = 1;
    private bool _dissolving;

    private void Update() {

        if(Input.GetKeyDown(KeyCode.D)){
            _dissolving = !_dissolving;

            if(_effect != null){
                _effect.SetActive(true);
            }
        }
    
        if(_dissolving){
            _dissolveAmount = Mathf.MoveTowards(_dissolveAmount, 0f, _dissolveSpeed * Time.deltaTime);
        }else{
            _dissolveAmount = Mathf.MoveTowards(_dissolveAmount, 1f, _dissolveSpeed * Time.deltaTime);
        }

        _renderer.material.SetFloat("_Cutoff", _dissolveAmount);

        if(_dissolveAmount <= 0.5f){
            _renderer.shadowCastingMode = UnityEngine.Rendering.ShadowCastingMode.Off;
        }else{
            _renderer.shadowCastingMode = UnityEngine.Rendering.ShadowCastingMode.On;
        }
    }
}