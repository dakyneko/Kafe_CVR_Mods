﻿using TMPro;

namespace CCK.Debugger.Events;

internal static class DebuggerMenu {

    public static event Action<bool> Pinned;
    public static event Action<bool> PointerToggled;
    public static event Action<bool> TriggerToggled;
    public static event Action<bool> ResetToggled;

    public static event Action MainNextPage;
    public static event Action MainPreviousPage;

    public static event Action ControlsNextPage;
    public static event Action ControlsPreviousPage;

    public static event Action<bool> SwitchedInspectedEntity;

    public static event Action<TextMeshProUGUI> TextMeshProUGUIDestroyed;

    public static void OnPinned(bool pinned) {
        Pinned?.Invoke(pinned);
    }
    public static void OnPointerToggle(bool pinned) {
        PointerToggled?.Invoke(pinned);
    }
    public static void OnTriggerToggle(bool pinned) {
        TriggerToggled?.Invoke(pinned);
    }
    public static void OnResetToggle(bool pinned) {
        ResetToggled?.Invoke(pinned);
    }

    public static void OnMainNextPage() {
        MainNextPage?.Invoke();
    }
    public static void OnMainPrevious() {
        MainPreviousPage?.Invoke();
    }

    public static void OnControlsNextPage() {
        ControlsNextPage?.Invoke();
    }
    public static void OnControlsPrevious() {
        ControlsPreviousPage?.Invoke();
    }

    public static void OnSwitchInspectedEntity(bool finishedInitializing) {
        SwitchedInspectedEntity?.Invoke(finishedInitializing);
    }

    public static void OnTextMeshProUGUIDestroyed(TextMeshProUGUI tmpText) {
        TextMeshProUGUIDestroyed?.Invoke(tmpText);
    }
}
