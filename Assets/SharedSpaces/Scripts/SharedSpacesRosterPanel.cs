// Copyright (c) Facebook, Inc. and its affiliates.

using UnityEngine;
using MLAPI;
using Oculus.Platform;

public class SharedSpacesRosterPanel : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (!other.GetComponent<NetworkObject>().IsOwner) return;

        GroupPresence.LaunchRosterPanel(new RosterOptions());
    }
}
