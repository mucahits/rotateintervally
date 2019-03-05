using UnityEngine;

public class RotateIntervally : MonoBehaviour {

    void Start () {

    }
	
    void Update () {
        transform.rotation = Quaternion.Euler(GetTargetEuler(Input.mousePosition, transform.position, 45f) * Vector3.forward);
    }

    public float GetTargetEuler(Vector3 touchPosition, Vector3 referencePosition, float interval){
        var v = touchPosition - Camera.main.WorldToScreenPoint(referencePosition);
        float currentAngle = Mathf.Atan2(v.y, v.x) * Mathf.Rad2Deg;
        currentAngle = (currentAngle > 0) ? currentAngle : currentAngle + 360f;

        var region = (int) Mathf.Floor(currentAngle / interval);

        return region * interval;

    }

}
