# Troubleshooting — OpenGalea

Common issues and fixes for building and running OpenGalea. For setup steps, see the [README](README.md) ([Hardware](README.md#6-hardware-setup), [Software](README.md#7-software-setup), [Running](README.md#9-running-opengalea)). For parts and cost, see [BOM.md](BOM.md) and [HARDWARE.md](HARDWARE.md).

---

## Hardware

### Headset / electrodes

- **Poor or noisy EEG signal** — Check electrode contact (reapply gel if using wet electrodes, or adjust dry-electrode position). Ensure the headset is snug; motion and loose electrodes cause artifact. See [HARDWARE.md](HARDWARE.md) for assembly and fit.
- **Headset uncomfortable or unstable** — Adjust Velcro straps and counterweights (see [HARDWARE.md](HARDWARE.md)). Balance the Cyton board and wiring so the assembly doesn’t tilt forward or back.
- **3D-printed parts don’t fit** — The Ultracortex can be trimmed for head size (see HARDWARE.md). Print at recommended layer height and infill from the [3d-models/](3d-models/) STLs.

### OpenBCI Cyton

- **Board not detected** — Confirm the USB dongle is plugged in and the Cyton is powered. Try another USB port; avoid hubs if possible. Check [OpenBCI documentation](https://openbci.com/documentation) for your board and dongle.
- **Dropped samples or disconnects** — Keep the dongle close to the headset; reduce obstacles between them. Restart the OpenBCI GUI and, if needed, re-pair the dongle.

---

## Software & data path

### OpenBCI GUI

- **No data in OpenBCI GUI** — Verify the correct serial port (or LSL stream) is selected. Confirm electrode connections and that the board is streaming; check OpenBCI docs for your OS.
- **Stream works in GUI but not in Unity / ML** — Ensure the same stream (e.g. LSL stream name or UDP port) is used in the GUI and in your Python/Unity config. Port conflicts with other apps can cause issues.

### Python / ML pipeline

- **`main_Attention.py` or model script fails** — Install dependencies (e.g. `pip install -r requirements.txt` in `Syncer/ML`). Confirm the path to the saved model (`random_forest_model_Attention_AlphaBeta.joblib`) is correct.
- **LSL: no stream found** — Start the OpenBCI GUI (or your LSL source) before starting the Python script. Check that the LSL stream name matches what the script expects.
- **UDP: Unity not receiving state** — Check firewall rules for the UDP port used between the ML script and Unity. Ensure the script is sending to the correct IP and port (localhost vs. Quest IP if applicable).

### Unity / Meta Quest

- **Build fails or Quest not listed** — Install Meta XR SDK and Quest build support in Unity. Enable Developer Mode on the Quest and connect via USB; accept the debugging prompt on the headset.
- **App runs on Quest but no BCI response** — Confirm the ML pipeline is running and sending over UDP to the address/port the Unity app uses. Check Unity console for UDP or BCI-related errors.
- **Colocation / multiplayer: devices don’t see each other** — Use the same Meta account (or colocation flow) as required by the Meta SDK. Ensure Bluetooth is on and devices are within range (~30 ft). All clients should be on a compatible build and network.

---

## Multiplayer & networking

- **Host or clients can’t connect** — Put all devices (laptops and Quests) on the same Wi‑Fi. Disable VPNs or guest networks that isolate devices. Check Unity `NetworkManager` (or equivalent) host/client setup.
- **Desync or lag** — Reduce Wi‑Fi congestion; place the router close to the play space. Ensure only one host and that all clients join the same session.

---

## Still stuck?

- **Documentation** — [README](README.md) · [HARDWARE.md](HARDWARE.md) · [BOM.md](BOM.md)
- **Contributing** — [CONTRIBUTING.md](CONTRIBUTING.md) (including how to suggest improvements to this guide)
- **Contact** — See [README § Contact](README.md#15-contact) for team emails; open an [Issue](https://github.com/Caerii/OpenGalea/issues) for bugs or doc gaps.
