# OpenGalea: Open-Source Neuroadaptive Mixed Reality

[![GitHub Repo stars](https://img.shields.io/github/stars/Caerii/OpenGalea?style=social)](https://github.com/Caerii/OpenGalea) [![GitHub forks](https://img.shields.io/github/forks/Caerii/OpenGalea?style=social)](https://github.com/Caerii/OpenGalea)
[![GitHub issues](https://img.shields.io/github/issues/sbpark422/Syncer)](https://github.com/sbpark422/Syncer/issues)
[![GitHub pull requests](https://img.shields.io/github/issues-pr/sbpark422/Syncer)](https://github.com/sbpark422/Syncer/pulls)
[![License](https://img.shields.io/badge/license-MIT-blue.svg)](https://opensource.org/licenses/MIT) [![Devpost](https://img.shields.io/badge/Devpost-OpenGalea-6C63FF?logo=devpost)](https://devpost.com/software/opengalea)

**By Team Syncer**

**[📋 View project on Devpost →](https://devpost.com/software/opengalea)** — Story, demo video, sizzle reel, and full hackathon submission.  
**Videos:** [Demo](https://youtu.be/qLijOJMBI6s) · [Sizzle reel](https://youtu.be/i-78e9bFQKs)

> **🏆 Meta track winner @ MIT Reality Hack 2025** — OpenGalea was awarded **5 Quest 3 headsets** by Meta, recognizing our brain-controlled, colocated multiplayer mixed reality system and supporting the next phase of development.

**Contributors:** Alif Jakir, Tsing Liu, Soo Bin Park, Yechan Ian Seo, Syed Hussain Ather  
**Special thanks** to Vankley Yi for hardware engineering support.

"We stuck together the Ultracortex with a Quest 3, but made space by giving the prefrontal cortex a lobotomy, and then we added a bunch of electrodes, and made a local multiplayer shared experience."

![Hardware design annotation](./hardware_design_annotation.png)

---

**Table of Contents**

1.  [Introduction](#introduction)
2.  [Project Genesis: MIT Reality Hack](#project-genesis-mit-reality-hack)
3.  [Features](#features)
4.  [Use Cases](#use-cases)
5.  [Bill of Materials (BOM)](#bill-of-materials-bom)
6.  [Hardware Setup](#hardware-setup)
    *   [6.1 3D Printing](#61-3d-printing)
    *   [6.2 Assembly](#62-assembly)
7.  [Software Setup](#software-setup)
    *   [7.1 Prerequisites](#71-prerequisites)
    *   [7.2 Installation](#72-installation)
8.  [Machine Learning Model](#machine-learning-model)
    *   [8.1 Data Collection](#81-data-collection)
    *   [8.2 Model Architecture](#82-model-architecture)
    *   [8.3 Training](#83-training)
    *   [8.4 Real-time Inferencing](#84-real-time-inferencing)
9.  [Running OpenGalea](#running-opengalea)
    *   [9.1 Single-Player Mode](#91-single-player-mode)
    *   [9.2 Multiplayer Mode](#92-multiplayer-mode)
10. [Colocation Implementation](#colocation-implementation)
11. [Troubleshooting](#troubleshooting)
12. [Contributing](#contributing)
13. [License](#license)
14. [Acknowledgements](#acknowledgements)
15. [Contact](#contact)
16. [Inspirations](#inspirations)
17. [Repositories & Links](#repositories)

---

## 1. Introduction <a name="introduction"></a>

OpenGalea is an open-source project that merges neuroscience and mixed reality into immersive, brain-controlled experiences. An 8-channel EEG system (OpenBCI Cyton) paired with the Meta Quest 3 lets users shape virtual environments with their brainwaves—no controllers required. We built it to **democratize neurotechnology**: at ~**15× lower cost** than commercial alternatives (OpenGalea ~$1,900 vs. Galea ~$30,000), it opens the door for researchers, developers, and enthusiasts to collect meaningful datasets and build entirely brain-driven, closed-loop visual and auditory experiences. The result is a platform where thought and presence share the same space.

## 2. Project Genesis: MIT Reality Hack <a name="project-genesis-mit-reality-hack"></a>

OpenGalea was conceived and built during the hardware track at [MIT Reality Hack](https://www.mitrealityhack.com/), a premier hackathon that brings together innovators in mixed reality, AI, hardware, and game development. The intensity of the hackathon—and the chance to iterate alongside other teams—pushed the project from concept to a working, multi-user system in days. At MIT Reality Hack 2025, OpenGalea was named **Meta track winner**, earning 5 Quest 3 headsets from Meta to scale our colocated multiplayer experiences and bring the vision to more users.

## 3. Features <a name="features"></a>

*   **Colocated Mixed Reality:** Shared virtual environments where multiple users share the same physical space—see each other, see the same virtual objects, and collaborate in real time.
*   **Brain-Computer Interface:** An 8-channel EEG system streams and analyzes brainwaves in real time, so attention, relaxation, and other states can drive the experience.
*   **Custom Machine Learning Model:** A trained classifier turns raw EEG into reliable mental-state labels (e.g., Attention, Relaxation), enabling responsive, brain-driven interactions.
*   **UDP Communication:** Low-latency links between EEG hardware, laptops, and the Quest 3 keep brain data and the MR experience in sync.
*   **Unity + Meta XR SDK:** Full mixed reality experiences built in Unity, with colocation and shared spatial anchors so everyone shares one coherent world.
*   **Open-Source and Affordable:** Hardware, software, and docs are open—so labs, indie devs, and makers can build without the six-figure price tag of commercial neuro-MR systems.

## 4. Use Cases <a name="use-cases"></a>

OpenGalea’s combination of BCI and colocated MR opens a wide range of applications:

*   **Gaming:** Brain-controlled mechanics—focus to aim, relax to trigger—for deeper immersion and new forms of interdependence between players.
*   **Therapeutic Applications:** Neuroadaptive environments that respond to attention and relaxation for meditation, stress reduction, and mental wellness.
*   **Collaborative Training:** Shared virtual simulations where teams train together in the same space, with feedback tied to mental state and cooperation.
*   **Accessibility:** Assistive interfaces that reduce reliance on physical input, enabling interaction through intention and focus.
*   **Non-Verbal Communication:** Shared experiences where emotional or cognitive state (e.g., calm vs. focused) becomes part of how people coordinate—without saying a word.

## 5. Bill of Materials (BOM) <a name="bill-of-materials-bom"></a>

Keeping the system affordable was a core goal: we want labs, educators, and indie creators to run experiments and build experiences without six-figure hardware. A detailed BOM, including component sources and costs, is available [here](link to your BOM - Google Sheet or Markdown table).

**Cost Comparison:**

*   **OpenGalea:** Approximately $1,900
*   **Commercial Equivalent (e.g., Galea):** Approximately $30,000

OpenGalea is approximately **15.8× more cost-effective** than comparable commercial systems—so neuroadaptive MR can move out of high-budget labs and into the wild.

## 6. Hardware Setup <a name="hardware-setup"></a>

### 6.1 3D Printing <a name="61-3d-printing"></a>

*   **Headset Components:** The front and back components of the OpenGalea headset are designed for 3D printing. STL files are available in the `OpenGalea/3d-models` directory of the [Hardware Repository](https://github.com/Caerii/OpenGalea).
*   **Recommended Materials:** PLA or PETG
*   **Print Settings:**
    *   Layer Height: 0.2mm
    *   Infill: 20-30%
    *   Supports: As needed
    *   Refer to your filament and printer documentation for specific temperature settings.

### 6.2 Assembly <a name="62-assembly"></a>

A detailed, step-by-step assembly guide with diagrams and photos is available in the [Hardware Repository's HARDWARE.md](https://github.com/Caerii/OpenGalea/blob/main/HARDWARE.md).

**Key Assembly Steps:**

1.  Prepare all components (3D printed parts, OpenBCI Cyton board, electrodes, wiring, Velcro straps).
2.  Assemble the Ultracortex frame (refer to OpenBCI Ultracortex Mark IV documentation if needed).
3.  Integrate the Cyton board onto the 3D printed back component.
4.  Attach electrodes and route wiring.
5.  Mount the front component to the Ultracortex frame.
6.  Add weights and Velcro straps for balance and fit.
7.  Connect the assembled system to the Quest 3 headset.

## 7. Software Setup <a name="software-setup"></a>

### 7.1 Prerequisites <a name="71-prerequisites"></a>

*   **Operating System:** Windows 10 or 11 (for OpenBCI GUI and model training)
*   **Unity:** Version 2022.3 or later
*   **Meta XR SDK:** Download and import into your Unity project
*   **OpenBCI GUI:** Download from the OpenBCI website
*   **Python:** Version 3.9 or later (for machine learning components)
*   **Python Libraries:**
    *   `numpy`
    *   `scipy`
    *   `scikit-learn`
    *   `joblib`
    *   `pylsl` (for Lab Streaming Layer)
    *   `websockets`
    *   Install using pip: `pip install numpy scipy scikit-learn joblib pylsl websockets`
*   **Visual Studio or Rider** (for C# development in Unity)
*   **Blender** (optional, for 3D model editing)

### 7.2 Installation <a name="72-installation"></a>

1.  **Clone the Repositories:**
    *   **Software Repository (Unity, ML, BCI):**
        ```bash
        git clone https://github.com/sbpark422/Syncer.git
        cd Syncer
        ```
    *   **Hardware Repository (Design Files + Hardware):**
        ```bash
        git clone https://github.com/Caerii/OpenGalea.git
        cd OpenGalea
        ```

2.  **Set up the Unity Project:**
    *   Open Unity Hub and create a new project using Unity 2022.3 or later.
    *   Import the Meta XR SDK.
    *   Copy the contents of the `Assets` directory from the `Syncer` repository into your Unity project's `Assets` folder.
3.  **Install Python Dependencies:**
    ```bash
    cd Syncer/ML # Navigate to the ML directory within the Syncer repo
    pip install -r requirements.txt
    ```
    (Create a `requirements.txt` file listing all Python dependencies within the `Syncer/ML` directory)
4. **Install OpenBCI GUI**
    * Download and install the OpenBCI GUI according to your operating system.

## 8. Machine Learning Model <a name="machine-learning-model"></a>

The ML pipeline turns raw EEG into actionable states (e.g., Attention vs. Relaxation) so the MR experience can respond in real time. Below is how we collect data, train the model, and run inference live.

### 8.1 Data Collection <a name="81-data-collection"></a>

*   EEG data was collected using the OpenBCI Cyton board and the provided Python script (`Syncer/ML/model_dev_Attention.py`).
*   Data was collected for two states: "Attention" and "Relaxation."
*   The dataset comprises 112,900 data points (498 seconds).
*   **Electrode Placement:**
    1.  **Fp1:** Left frontal lobe
    2.  **Fp2:** Right frontal lobe
    3.  **C3:** Left central region
    4.  **C4:** Right central region
    5.  **T5:** Left temporal lobe
    6.  **T6:** Right temporal lobe
    7.  **O1:** Left occipital lobe
    8.  **O2:** Right occipital lobe

### 8.2 Model Architecture <a name="82-model-architecture"></a>

*   A modified Random Forest algorithm was used for classification.
*   **Features:** Raw EEG data, alpha wave band power, and beta wave band power.

### 8.3 Training <a name="83-training"></a>

*   The model was trained using the collected EEG data and saved as `Syncer/ML/random_forest_model_Attention_AlphaBeta.joblib`.
*   Training scripts and details are available in the `Syncer/ML` directory.

### 8.4 Real-time Inferencing <a name="84-real-time-inferencing"></a>

*   The `Syncer/ML/main_Attention.py` script loads the trained model and performs real-time inferencing on incoming EEG data from the Cyton board via LSL.
*   Inferencing is performed on 1-second time windows, with results updated every second.

## 9. Running OpenGalea <a name="running-opengalea"></a>

Once hardware is assembled and software is installed, you can run OpenGalea in single-player or multiplayer mode.

### 9.1 Single-Player Mode <a name="91-single-player-mode"></a>

1.  **Hardware Setup:** Assemble the OpenGalea headset and connect it to your Quest 3. Connect the OpenBCI Cyton board to your laptop.
2.  **Software Setup:**
    *   Launch the OpenBCI GUI and start streaming EEG data.
    *   Run the `main_Attention.py` script from the `Syncer/ML` directory to start the machine learning model and begin real-time inferencing.
    *   Open the OpenGalea Unity project and build/deploy it to your Quest 3.
3.  **Start the Experience:** Launch the OpenGalea app on your Quest 3.

### 9.2 Multiplayer Mode <a name="92-multiplayer-mode"></a>

In our example app, multiple users collaborate using their BCI alpha channels: each user's alpha values are visualized as pillars, and users help a running character jump over obstacles by entering a rest state (high alpha) when the character needs to jump.

1.  **Hardware Setup:** Each participant needs a fully assembled OpenGalea headset, a Quest 3, and a laptop.
2.  **Software Setup:**
    *   Ensure all devices are on the same Wi-Fi network.
    *   Launch the OpenBCI GUI on each laptop and start streaming EEG data.
    *   Run the `main_Attention.py` script on each laptop.
    *   Open the OpenGalea Unity project.
    *   Configure the `NetworkManager` in Unity to designate one device as the host and the others as clients.
    *   Build/deploy the app to all Quest 3 devices.
3.  **Start the Experience:** Launch the OpenGalea app on all Quest 3 devices. The host should initiate the shared experience.

## 10. Colocation Implementation <a name="colocation-implementation"></a>

Colocation is what makes OpenGalea feel shared: everyone inhabits the same physical room and the same virtual layer, so cooperation is natural and spatial. We use Meta’s Colocation and Shared Spatial Anchors APIs to make that possible.

*   **Colocation Discovery:** Devices discover each other over Bluetooth within ~30 feet. The Colocation API lets each headset advertise its session and find nearby peers so users can join without manual IPs or codes.
*   **Shared Spatial Anchors:** Once connected, shared anchors lock virtual objects to the same spots in the room for every user—so a virtual pillar or character stays where you expect it, for everyone.
*   **Synchronization:** We keep device state and object updates in sync so that all users see and interact with the same virtual world at the same time, with minimal lag or drift.

## 11. Troubleshooting <a name="troubleshooting"></a>

Refer to the [Troubleshooting Guide](link to troubleshooting guide - can be a separate Markdown file or a section in the README) for solutions to common issues.

## 12. Contributing <a name="contributing"></a>

OpenGalea is meant to grow with the community—whether you’re into hardware, ML, Unity, or UX, there’s room to help. We welcome contributions of all kinds. Please see our [Contribution Guidelines](CONTRIBUTING.md) for how to get involved.

## 13. License <a name="license"></a>

This project is licensed under the [MIT License](LICENSE).

## 14. Acknowledgements <a name="acknowledgements"></a>

*   [MIT Reality Hack](https://www.mitrealityhack.com/)
*   [OpenBCI](https://openbci.com/)
*   [Meta](https://www.meta.com/)
*   **Vankley Yi** — hardware engineering support

## 15. Contact <a name="contact"></a>

For questions or inquiries, please contact:

*   [sbpark422@gmail.com (Soo Bin); tsingliu2020@gmail.com (Tsing); cds07012@gmail.com (Yechan); shussainather@gmail.com (Hussain); cubelocked@gmail.com (Alif)]

## 16. Inspirations <a name="inspirations"></a>

We drew on sci-fi and pop culture for the *feel* of brain-linked collaboration:

*   **Pacific Rim** — Pilots neurally linked to share control and intention.
*   **Cerebro (X-Men)** — A device that reads and connects minds across space.
*   **Neon Genesis Evangelion** — Synchronization between pilot and machine, and between pilots, as the key to cooperation.

## 17. Repositories & Links <a name="repositories"></a>
*   **Software (Unity, ML, BCI):** [Syncer](https://github.com/sbpark422/Syncer)
*   **Hardware (Design Files):** [OpenGalea](https://github.com/Caerii/OpenGalea)
*   **Devpost:** [OpenGalea project page](https://devpost.com/software/opengalea)
*   **Demo video:** [YouTube](https://youtu.be/qLijOJMBI6s)
*   **Sizzle reel:** [YouTube](https://youtu.be/i-78e9bFQKs)