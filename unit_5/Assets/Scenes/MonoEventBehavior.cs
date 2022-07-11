
using UnityEngine;
using UnityEngine.Events;


public class MonoEventBehavior : MonoBehaviour
{
   public UnityEvent starEvent, awakeEvent, disableEvent;

   private void Awake()

   {
    awakeEvent.Invoke();
   }

   private void Start()
   {
    starEvent.Invoke();
   }

   private void OnBecameVisible()
   {
    disableEvent.Invoke();
   }

}