# OpenGalea: Open-Source Neuroadaptive Mixed Reality

[![GitHub Repo stars](https://img.shields.io/github/stars/Caerii/OpenGalea?style=social)](https://github.com/Caerii/OpenGalea) [![GitHub forks](https://img.shields.io/github/forks/Caerii/OpenGalea?style=social)](https://github.com/Caerii/OpenGalea)
[![GitHub issues](https://img.shields.io/github/issues/sbpark422/Syncer)](https://github.com/sbpark422/Syncer/issues)
[![GitHub pull requests](https://img.shields.io/github/issues-pr/sbpark422/Syncer)](https://github.com/sbpark422/Syncer/pulls)
[![License](https://img.shields.io/badge/license-MIT-blue.svg)](https://opensource.org/licenses/MIT)

**By Team Syncer**

**Contributors:** Alif Jakir, Tsing Liu, Soo Bin Park, Yechan Ian Seo, Syed Hussain Ather

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
17. [Repositories](#repositories)

---

## 1. Introduction <a name="introduction"></a>

OpenGalea is an open-source project that merges neuroscience and mixed reality to create immersive, brain-controlled experiences. By combining an 8-channel EEG system (based on the OpenBCI Cyton board) with the Meta Quest 3, OpenGalea enables users to interact with virtual environments using their brainwaves. This project aims to democratize neurotechnology, making it more accessible and affordable for researchers, developers, and enthusiasts. OpenGalea offers an accessible and open-source solution for creating valuable datasets and interactive closed-loop visual and auditory experiences that are entirely brain-controlled.

## 2. Project Genesis: MIT Reality Hack <a name="project-genesis-mit-reality-hack"></a>

OpenGalea was conceived and developed during the hardware track at [MIT Reality Hack](https://www.mitrealityhack.com/), a renowned annual hackathon that brings together innovators to push the boundaries of mixed reality, AI, hardware, software, and game development.

## 3. Features <a name="features"></a>

*   **Colocated Mixed Reality:** Supports shared virtual environments where multiple users can interact in the same physical space.
*   **Brain-Computer Interface:** Integrates an 8-channel EEG system for real-time brainwave analysis.
*   **Custom Machine Learning Model:** Utilizes a trained ML model for accurate classification of mental states (e.g., Attention, Relaxation).
*   **UDP Communication:** Facilitates seamless communication between EEG hardware, laptops, and the Quest 3 headset.
*   **Unity Development:** Leverages the Unity platform and Meta XR SDK for creating immersive mixed reality experiences.
*   **Open-Source and Affordable:** Provides a cost-effective alternative to expensive commercial neurotechnology solutions.

## 4. Use Cases <a name="use-cases"></a>

*   **Gaming:** Develop brain-controlled game mechanics for more immersive experiences.
*   **Therapeutic Applications:** Create neuroadaptive environments for meditation, relaxation, and mental wellness.
*   **Collaborative Training:** Enhance team-based training through shared virtual simulations.
*   **Accessibility:** Provide assistive technology for individuals with disabilities.
*   **Non-Verbal Communication**

## 5. Bill of Materials (BOM) <a name="bill-of-materials-bom"></a>

A detailed BOM, including component sources and costs, is available [here](link to your BOM - Google Sheet or Markdown table).

**Cost Comparison:**

*   **OpenGalea:** Approximately $1,900
*   **Commercial Equivalent (e.g., Galea):** Approximately $30,000

OpenGalea is approximately **15.8 times more cost-effective** than comparable commercial systems.

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
        git clone [[https://github.com/sbpark422/Syncer.git](https://www.google.com/search?q=https://github.com/sbpark422/Syncer.git)]([https://github.com/sbpark422/Syncer.git](https://www.google.com/search?q=https://github.com/sbpark422/Syncer.git))
        cd Syncer
        ```
    *   **Hardware Repository (Design Files + Hardware):**
        ```bash
        git clone [[https://github.com/Caerii/OpenGalea.git](https://www.google.com/search?q=https://github.com/Caerii/OpenGalea.git)]([https://github.com/Caerii/OpenGalea.git](https://www.google.com/search?q=https://github.com/Caerii/OpenGalea.git))
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

### 9.1 Single-Player Mode <a name="91-single-player-mode"></a>

1.  **Hardware Setup:** Assemble the OpenGalea headset and connect it to your Quest 3. Connect the OpenBCI Cyton board to your laptop.
2.  **Software Setup:**
    *   Launch the OpenBCI GUI and start streaming EEG data.
    *   Run the `main_Attention.py` script from the `Syncer/ML` directory to start the machine learning model and begin real-time inferencing.
    *   Open the OpenGalea Unity project and build/deploy it to your Quest 3.
3.  **Start the Experience:** Launch the OpenGalea app on your Quest 3.

### 9.2 Multiplayer Mode <a name="92-multiplayer-mode"></a>

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
OpenGalea utilizes Meta's Colocation and Shared Spatial Anchors APIs to create shared mixed reality experiences.

*   **Colocation Discovery Initialization**
    *   Devices running OpenGalea utilize Bluetooth-based discovery to identify each other within a range of approximately 30 feet. The Colocation API allows devices to advertise their presence and discover nearby sessions.
*   **Shared Spatial Anchors**
    *   Once devices are connected, shared spatial anchors ensure that virtual objects are consistently positioned within the physical space for all users.
*   **Synchronization**
    *   Maintaining synchronization between devices is crucial for a seamless shared experience. OpenGalea employs various techniques to ensure that all users see and interact with the same virtual objects at the same time.

## 11. Troubleshooting <a name="troubleshooting"></a>

Refer to the [Troubleshooting Guide](link to troubleshooting guide - can be a separate Markdown file or a section in the README) for solutions to common issues.

## 12. Contributing <a name="contributing"></a>

We welcome contributions to OpenGalea! Please see our [Contribution Guidelines](link to contributing guidelines - can be a `CONTRIBUTING.md` file) for details on how to get involved.

## 13. License <a name="license"></a>

This project is licensed under the [MIT License](LICENSE).

## 14. Acknowledgements <a name="acknowledgements"></a>

*   [MIT Reality Hack](https://www.mitrealityhack.com/)
*   [OpenBCI](https://openbci.com/)
*   [Meta](https://www.meta.com/)

## 15. Contact <a name="contact"></a>

For questions or inquiries, please contact:

*   [sbpark422@gmail.com (Soo Bin); tsingliu2020@gmail.com (Tsing); cds07012@gmail.com (Yechan); shussainather@gmail.com (Hussain); cubelocked@gmail.com (Alif)]

## 16. Inspirations <a name="inspirations"></a>
*   Pacific Rim
*   Cerebro (X-Men)
*   Neon Genesis Evangelion

## 17. Repositories <a name="repositories"></a>
*   **Software (Unity, ML, BCI):** [https://github.com/sbpark422/Syncer](https://github.com/sbpark422/Syncer)
*   **Hardware (Design Files):** [https://github.com/Caerii/OpenGalea](https://github.com/Caerii/OpenGalea)