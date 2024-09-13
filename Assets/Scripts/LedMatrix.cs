using UnityEngine;

public class LedMatrix : MonoBehaviour
{   
    // [SerializeField] Transform sweepingObject;  // Reference to the sweeping object
    // [SerializeField] Renderer targetRenderer;   // Reference to the asset's Renderer component
    // private Material targetMaterial;            // Material that has the shader

    // [SerializeField] float rotateSpeed;
    // [SerializeField] Vector3 rotationDirection = new Vector3();

    // private Transform childTransform;

    // private void Start(){
    //     if (targetRenderer != null){
    //         targetMaterial = targetRenderer.material;
    //     }
    //     childTransform = transform.GetChild(0);
    // }

    // // Update is called once per frame
    // private void Update()
    // {   
    //     if (targetMaterial != null){
    //         transform.Rotate(rotateSpeed * Time.deltaTime * rotationDirection);

    //         // Pass the sweeping object's position to the shader
    //         targetMaterial.SetVector("_SweepingObjectPosition", sweepingObject.position);

    //         // Pass the sweeping object's position to the shader
    //         targetMaterial.SetVector("_SweepingObjectNormal", sweepingObject.forward);

    //         // Pass the sweeping object's position to the shader
    //         targetMaterial.SetVector("_SweepingObjectScale", childTransform.localScale);
    //         Debug.Log(sweepingObject.position);
    //     }
    // }

    [SerializeField] float rotateSpeed;
    [SerializeField] Vector3 rotationDirection = new();
    [SerializeField] Renderer targetRenderer;   // Reference to the asset's Renderer component


    private Material targetMaterial; 
    private Transform childTransform; 

    private void Start(){
        if (targetRenderer != null){
            targetMaterial = targetRenderer.material;
        }
        childTransform = transform.GetChild(0);
    }

    private void Update(){
        if (targetMaterial != null){
            // Rotates the LED Matrix
            transform.Rotate(rotateSpeed * Time.deltaTime * rotationDirection);
            targetMaterial.SetVector("_SweepingObjectPosition", childTransform.position);
            targetMaterial.SetVector("_SweepingObjectNormal", childTransform.forward);
            targetMaterial.SetVector("_SweepingObjectScale", childTransform.localScale);
            Debug.Log(childTransform.forward);
        }
    }
}
