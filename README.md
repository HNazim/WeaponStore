# 🛠️ Unity Weapon Store (MVC + ScriptableObject)

A modular and scalable **Weapon Store System** built in Unity using **ScriptableObjects** and the **Model-View-Controller (MVC)** architectural pattern. This project demonstrates a clean, maintainable code structure for data-driven inventory systems in Unity.

## 🎯 Project Overview

This project serves as a weapon shop interface where users can browse, view, and purchase different weapons. It emphasizes **separation of concerns** using MVC and utilizes **ScriptableObjects** for efficient data handling, serialization, and asset management.

---

## 🧱 Architecture: MVC Pattern

- **Model**: Contains weapon data (name, price, stats, etc.) using `ScriptableObject` assets.
- **View**: Unity UI elements that visually represent the weapons and store interface.
- **Controller**: Mediates interaction between the UI and data; handles selection, purchasing logic, and updates.

---

## 📦 Features

- ✅ Dynamic weapon loading from ScriptableObjects  
- ✅ MVC architecture for clean separation of logic  
- ✅ Purchase logic with validation  
- ✅ Inspector-friendly weapon data definition  
- ✅ Extendable system for categories, currencies, etc.  
- ✅ Developer-friendly code with clear comments

---


---

## 🚀 Getting Started

1. Clone this repository.
2. Open the project in Unity (tested on **Unity 2021.3+**).
3. Go to `Scenes/WeaponStore.unity`.
4. Press ▶ to run the store interface.

---

## 🧠 How to Use

- Create new weapons via `Assets → Create → Weapon Data`.
- Configure stats, cost, and visual assets through the inspector.
- Add them to the store list managed by the controller.

---

## 🛠️ Customization

- To support new weapon types or UI skins, extend the `WeaponView` prefab and modify the controller logic accordingly.
- Integrate your own economy system by modifying the controller’s purchase method.

---

## 📌 Best Practices Used

- 🧩 **ScriptableObject** for modular, inspector-editable data
- 🧼 **MVC pattern** to promote code clarity and testability
- 💡 **Single Responsibility Principle** across components
- 🗂️ **Decoupled UI logic** from game mechanics

---

## 📷 Screenshots

> *(Include 1–2 images of the store UI if available)*

---

## 📄 License

MIT License – Feel free to use and modify!

---

## 🙌 Contributions

PRs, feedback, and suggestions are welcome! Please follow clean code principles and Unity conventions.

---

## 🔗 Related

- Unity Documentation – [ScriptableObject](https://docs.unity3d.com/Manual/class-ScriptableObject.html)
- Unity Learn – [MVC in Unity](https://learn.unity.com/tutorial/mvc-architecture)


