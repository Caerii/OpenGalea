# Contributing to OpenGalea

🚀 **Welcome to OpenGalea!** Thank you for your interest in contributing to our open-source **Neuroadaptive Mixed Reality** project. OpenGalea integrates **EEG-based brainwave interactions** with **Meta Quest 3 and Unity**, and we are excited to have you join us in shaping the future of **brain-computer interfaces (BCI)** in mixed reality.  

This guide will help you get started with contributing to the project. Whether you're a **developer, researcher, designer, or enthusiast**, there's something for you!

---

## 🏗 Project Overview
OpenGalea is an **open-source brain-computer interface (BCI) for mixed reality (MR)**, integrating EEG signals with Meta Quest 3. Key features include:
- **Multiplayer EEG-based interactions** in shared MR spaces
- **Real-time brainwave classification** using machine learning
- **Customizable Unity-based neuroadaptive environments**
- **Affordable alternative** to commercial BCI solutions

We welcome contributions in **software, machine learning, hardware design, and UI/UX improvements**!

---

## 💡 How to Get Started

### 1️⃣ **Find an Issue to Work On**
- Check out our **[Open Issues](https://github.com/Caerii/OpenGalea/issues)**.
- Look for labels like:
  - `good first issue` → Beginner-friendly tasks.
  - `help wanted` → Issues where community input is needed.
  - `enhancement` → New features & improvements.
- If you're unsure, drop a comment on an issue or ask in **[Discussions](https://github.com/Caerii/OpenGalea/discussions)**!

### 2️⃣ **Set Up the Project Locally**
#### 🖥 Prerequisites:
- **Unity 2022.3+** (for MR development)
- **Meta XR SDK** (for Quest 3 integration)
- **Python 3.9+** (for ML-based EEG processing)
- **OpenBCI GUI** (for EEG data collection)

#### 🔧 Steps:
1. **Fork this repository** and clone your fork:
   ```bash
   git clone https://github.com/your-username/OpenGalea.git
   cd OpenGalea
   ```
2. **Set up Unity Project**:
   - Open **Unity Hub** → Add/Open the `OpenGalea/UnityProject` folder.
   - Import the **Meta XR SDK** package.
3. **Install Python Dependencies**:
   ```bash
   cd Syncer/ML
   pip install -r requirements.txt
   ```
4. **Test Your Setup**:
   - Run the **EEG ML pipeline**: `python main_Attention.py`
   - Open the **Unity project** and play the scene.

---

## 🛠 How to Contribute
### **1. Code Contributions** (Bug Fixes, Features, Improvements)
- **Step 1:** Pick an issue from **[Open Issues](https://github.com/Caerii/OpenGalea/issues)**.
- **Step 2:** Create a new branch:
  ```bash
  git checkout -b feature-new-idea
  ```
- **Step 3:** Commit your changes:
  ```bash
  git commit -m "Added new brainwave UI visualization"
  ```
- **Step 4:** Push to your fork and submit a **Pull Request (PR)**:
  ```bash
  git push origin feature-new-idea
  ```
- **Step 5:** Tag a maintainer and request a review!

### **2. Documentation & Research Contributions**
- Improve **README.md** with better setup guides.
- Add **explanations on EEG signals, MR design, or machine learning models**.
- Help build a **troubleshooting guide**.

### **3. UI/UX & Design Contributions**
- Improve **brainwave visualization in Unity**.
- Enhance the **user interface for EEG interactions**.
- Suggest **new neuroadaptive interaction ideas**.

### **4. Hardware Contributions**
- Optimize **EEG headset comfort & fit**.
- Improve **electrode placement guides**.
- Test **alternative EEG devices** for compatibility.

---

## ✅ Contribution Guidelines
### **Coding Style & Best Practices**
- Follow **PEP8** for Python.
- Use **meaningful commit messages**.
- Keep PRs **focused and small**—1 feature/fix per PR.
- Write **comments and documentation** where needed.

### **Pull Request (PR) Review Process**
- Ensure your **branch is up to date** before opening a PR.
- PRs will be reviewed within **48-72 hours**.
- If requested, **make changes and update your PR**.
- Once approved, the PR will be **merged into `main`**.

---

## 💬 Join the Conversation!
We’re building **a community around neuroadaptive technology**, and we’d love to have you involved!
- **GitHub Discussions** → [Ask questions, share ideas](https://github.com/Caerii/OpenGalea/discussions)
- **Twitter/X** → Tag us at `@OpenGalea`
- **Reddit r/NeuroTech** → Post ideas & feedback

For direct questions, contact:  
📧 **sbpark422@gmail.com (Soo Bin)**  
📧 **shussainather@gmail.com (Hussain)**

---

## 🏆 Recognition & Rewards
We appreciate our contributors and give **shoutouts** to top contributors on:
✅ **GitHub README** (Hall of Fame section)
✅ **Social media posts**
✅ **Invites to future OpenGalea research projects**

---

## 🔥 Ready to Contribute?
1️⃣ **Pick an issue** from [GitHub Issues](https://github.com/Caerii/OpenGalea/issues)  
2️⃣ **Fork & clone the repo**, make your changes  
3️⃣ **Submit a PR** and request a review 🎉

Thank you for being part of **OpenGalea** – let’s revolutionize **brain-controlled mixed reality** together! 🧠🚀


