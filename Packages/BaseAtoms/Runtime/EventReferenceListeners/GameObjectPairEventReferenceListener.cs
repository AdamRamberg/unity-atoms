using UnityEngine;

namespace UnityAtoms.BaseAtoms
{
    /// <summary>
    /// Event Reference Listener of type `GameObjectPair`. Inherits from `AtomEventReferenceListener&lt;GameObjectPair, GameObjectPairAction, GameObjectPairEvent, GameObjectPairEventReference, GameObjectPairUnityEvent&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-orange")]
    [AddComponentMenu("Unity Atoms/Event Reference Listeners/GameObjectPair Event Reference Listener")]
    public sealed class GameObjectPairEventReferenceListener : AtomEventReferenceListener<
        GameObjectPair,
        GameObjectPairAction,
        GameObjectPairEvent,
        GameObjectPairEventReference,
        GameObjectPairUnityEvent>
    { }
}