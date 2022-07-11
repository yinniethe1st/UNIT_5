


using UnityEngine;
using UnityEngine.Events;


public class MonoEventBehavior : MonoBehaviour
{
   public UnityEvent OnTriggerStayEvent, DestroyEvent, OnCollisionEvent;

   private void OnTriggerStay()

   {
    OnTriggerStayEvent.Invoke();
   }

   private void OnDestroy()
   {
    DestroyEvent.Invoke();
   }

   private void OnCollisionEnter()
   {
    OnCollisionEvent.Invoke();
   }

}
