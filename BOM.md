# Bill of Materials (BOM) — OpenGalea

Approximate cost to build one OpenGalea system (one user). Prices are in USD and may vary; check linked sources for current availability and pricing.

| Category | Item | Qty | Approx. price (USD) | Notes / source |
|----------|------|-----|---------------------|----------------|
| **EEG** | OpenBCI Cyton 8-channel board | 1 | ~500 | [OpenBCI](https://openbci.com/) — 8-channel biosensing board |
| **EEG** | USB dongle (for Cyton wireless) | 1 | ~25 | OpenBCI store — required for laptop link |
| **EEG** | Gold cup electrodes (8-channel) | 8+ | ~50–80 | OpenBCI or equivalent — reusable dry or wet electrodes |
| **EEG** | Ultracortex Mark IV (or equivalent) | 1 | ~100–150 | OpenBCI — headset frame; we use a modified version (see [HARDWARE.md](HARDWARE.md)) |
| **MR** | Meta Quest 3 (128 GB) | 1 | ~500 | [Meta](https://www.meta.com/quest/) — or use existing headset |
| **Fabrication** | 3D-printed front & back (OpenGalea) | 1 set | ~15–30 | Print from [3d-models/](3d-models/) — PLA/PETG; cost is filament if you have access to a printer |
| **Assembly** | Velcro straps, wiring, counterweights | 1 set | ~20–40 | For fit, cable routing, and balance (see [HARDWARE.md](HARDWARE.md)) |
| **Optional** | Conductive gel or paste | 1 | ~10–20 | For better electrode contact if using wet electrodes |
| **Optional** | Laptop (Windows 10/11) | 1 | — | For OpenBCI GUI + ML; often already available |

**Rough total (per user, excluding laptop):** ~**$1,200–1,400** if you already have a Quest 3; **~$1,700–1,900** including a new Quest 3.

---

**Notes**

- **Quest 3:** Can be shared across projects; not required to buy per OpenGalea build if you already have one.
- **Laptop:** One per user for running OpenBCI GUI and the ML inference script; not included in the per-unit BOM total.
- **3D printing:** STL files are in this repo under `3d-models/`. Printing services can be used if you don’t have a printer.
- **Comparison:** Commercial systems (e.g. Galea) are on the order of ~$30,000; OpenGalea targets ~15× lower cost for comparable neuroadaptive MR capability.

For assembly steps and hardware details, see [HARDWARE.md](HARDWARE.md) and the [README](README.md#6-hardware-setup). For common build and runtime issues, see [TROUBLESHOOTING.md](TROUBLESHOOTING.md).
