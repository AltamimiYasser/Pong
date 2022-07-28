using UnityEngine;
using UnityEngine.EventSystems;


public class ScoringZone : MonoBehaviour
{
    [SerializeField] EventTrigger.TriggerEvent scoreTrigger;
    void OnCollisionEnter2D(Collision2D other)
    {
        BallMovment ball = other.gameObject.GetComponent<BallMovment>();

        if (ball != null)
        {
            BaseEventData eventData = new BaseEventData(EventSystem.current);
            scoreTrigger.Invoke(eventData);
        }
    }
}
