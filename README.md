# 🐸 Slippy Frog

A 2D endless runner game built with Unity where you help a frog survive on a slippery surface — jump, dodge, and don't fall off!

---

## 🎮 Gameplay

- The surface constantly moves forward
- Tap/click to make the frog jump
- Avoid falling off the edge
- Survive as long as possible to complete levels

---

## 🛠️ Built With

- **Unity** (2D)
- **C#**
- **ShaderLab / HLSL** (custom shaders)

---

## 📁 Project Structure

```
Slippy-Frog/
├── Assets/
│   ├── Scripts/        # C# game scripts
│   ├── Scenes/         # Game scenes (Main Menu, Levels)
│   ├── Audio/          # Sound effects and background music
│   └── ...
├── Packages/
└── ProjectSettings/
```

---

## ⚙️ Key Scripts

### `GameManager.cs`
The core manager that controls game state.
- Singleton pattern — only one instance exists at a time
- Controls surface speed via `SurfaceEffector2D`
- Handles **level completion** and **game over** logic
- Manages background music volume

### `OptionsMenu.cs`
Handles the in-game options/settings UI.
- Controls background music volume via slider
- Saves volume settings with `PlayerPrefs` so they persist between sessions and scenes

---

## 🔊 Audio System

Volume settings are saved using `PlayerPrefs`, meaning:
- Settings persist even after the game is closed
- The main menu slider controls audio in all scenes
- Background music and sound effects are controlled separately

---

## 🚀 Getting Started

1. Clone the repository:
   ```bash
   git clone https://github.com/ogzrealm/Slippy-Frog.git
   ```
2. Open the project in **Unity 2022+**
3. Open the `MainMenu` scene from the Scenes folder
4. Press **Play** in the Unity Editor

---

## 👤 Developer

Made by [ogzrealm](https://github.com/ogzrealm) — a Unity game development journey, one frog at a time. 🐸
