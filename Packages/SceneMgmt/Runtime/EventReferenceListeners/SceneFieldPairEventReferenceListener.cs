using UnityEngine;
using UnityAtoms.SceneMgmt;

namespace UnityAtoms.SceneMgmt
{
    /// <summary>
    /// Event Reference Listener of type `SceneFieldPair`. Inherits from `AtomEventReferenceListener&lt;SceneFieldPair, SceneFieldPairAction, SceneFieldPairEvent, SceneFieldPairEventReference, SceneFieldPairUnityEvent&gt;`.
    /// </summary>
    [EditorIcon("atom-icon-orange")]
    [AddComponentMenu("Unity Atoms/Event Reference Listeners/SceneFieldPair Event Reference Listener")]
    public sealed class SceneFieldPairEventReferenceListener : AtomEventReferenceListener<
        SceneFieldPair,
        SceneFieldPairAction,
        SceneFieldPairEvent,
        SceneFieldPairEventReference,
        SceneFieldPairUnityEvent>
    { }
}