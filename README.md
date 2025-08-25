# 👻 Meta Quest 3 Ghost Shooter

> An immersive **mixed reality ghost‑hunting** game for **Meta Quest 3** built with **Unity**. Ghosts spawn behind the **scanned room mesh**, chase you with **NavMesh AI**, and can be zapped with a **laser gun** that fires physics‑accurate **raycasts**. Hits turn ghosts **red** before a smooth **death animation** plays and they **disappear**. Your **score** floats above the gun for instant feedback.

![Gameplay Screenshot](demo.gif)

---

## ✨ Features

* **Room‑aware MR gameplay** – Uses the scanned **room mesh** so ghosts appear from behind real furniture/walls.
* **NavMesh AI** – Enemies navigate around obstacles and **follow the player** intelligently.
* **Laser gun & ray hits** – Fires a raycast; on contact the ghost **flashes red**, plays a **death VFX**, then despawns.
* **Diegetic HUD** – **Score** is rendered **above the weapon** in world space.
* **Configurable spawning** – Tweak spawn radius, cadence, max concurrent ghosts.

---

## 🧰 Tech Stack

* **Unity** (C#) — recommended **2022.3 LTS**
* **Meta Quest / Meta XR (Oculus) SDK** — Quest 3
* **Unity NavMesh** — pathfinding & pursuit
* **XR Interaction** / input for gun handling

---

## 📺 Demo

* **YouTube:** [https://www.youtube.com/watch?v=Yrfx4ss8Wbw](https://www.youtube.com/shorts/fccMyw9vJjM)

---

## 🚀 Getting Started

### 1) Clone

```bash
git clone https://github.com/yourname/GhostShooter.git
cd GhostShooter
```

### 2) Open in Unity

* Use **Unity 2022.3 LTS** (or newer compatible with your Meta XR SDK).
* Install **Android Build Support** (SDK/NDK, OpenJDK).

### 3) Project Setup (Quest 3)

1. **XR Plugin Management** → enable **Oculus** for **Android**.
2. Import **Meta XR / Oculus Integration** (or Meta XR Core SDK) via Package Manager/Asset Store.
3. **Build Settings** → Switch Platform to **Android**.
4. **Player Settings** →

   * Graphics API: Vulkan or OpenGLES3 (either is fine for this project).
   * Minimum API Level: Android 10 (API 29) or higher.
   * Set **Target Devices** to Quest.
5. Enable **Developer Mode** on your Quest 3 (in the Meta app) and connect via USB/Air Link.

### 4) Build & Run

* `File → Build And Run` (device connected), or generate an **APK** and sideload.

---

## 🎮 How to Play

* **Move**: Walk around your real room (room‑scale MR).
* **Aim**: Point the controller at ghosts.
* **Shoot**: Pull the **trigger** to fire the laser ray.
* **Goal**: Survive and **rack up points**; score updates above your gun after each kill.

---

## ⚙️ Key Systems

* **Spawn Manager** — places ghosts just outside view/behind mesh, respecting max count & cooldowns.
* **NavMesh Agent** — pursues the player; updates destination periodically.
* **Raycast Damage** — gun emits a ray; ghosts implement `IHittable` to receive damage events.
* **Hit/Death Feedback** — shader color lerp to **red**, animation timeline, then despawn/pool.
* **World‑Space Score** — TextMeshPro anchored to the gun; increments on `OnGhostKilled` event.

---

## 🧪 Tuning (Inspector)

* `GhostSpawner`: spawn radius, spawn interval, max ghosts, spawn behind‑mesh bias.
* `GhostNavAgent`: move speed, acceleration, stopping distance.
* `LaserGun`: fire rate, max distance, hit layer mask.

---

## 🛣️ Roadmap

* Multiple ghost **archetypes** (fast, tanky, phasing through walls, ranged).
* **Power‑ups** (rapid fire, shield, slow‑mo).
* **Audio** pass (spatial SFX, music, haptics).
* **Leaderboards** and basic progression.
* **Co‑op** local/networked mode.

---

## 🤝 Contributing

PRs and issues are welcome! Please open an issue for bugs/ideas or submit a PR with a clear description and test steps.

---

## 📜 License

This project is released under the **MIT License**. See `LICENSE` for details.

---

## 🙌 Credits

Built by **Amr Khaled**

* GitHub: [https://github.com/amrkhaled229](https://github.com/amrkhaled229)
* LinkedIn: [https://linkedin.com/in/amrkhaled229](https://linkedin.com/in/amrkhaled229)
