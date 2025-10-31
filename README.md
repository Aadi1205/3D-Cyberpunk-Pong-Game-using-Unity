# 3D-Cyberpunk-Pong-Game-using-Unity
# 🎮 3D Cyberpunk Pong Game using Unity

A futuristic and immersive take on the classic **Pong**, built entirely in **Unity 3D** using **C#**.  
This project was developed as part of a college submission and demonstrates a beginner-friendly yet professional approach to **game design, scripting, and visual polish** in Unity.

---

## 🧠 Project Overview

The **3D Cyberpunk Pong Game** blends the simplicity of traditional Pong with a high-tech, neon-lit cyberpunk atmosphere.  
The game features two rackets (one controlled by a player, the other by AI), a physics-based ball, real-time scoring, and countdown-based gameplay.  
It showcases Unity fundamentals — from physics and input systems to UI design and event-driven scripting — while applying software engineering best practices.

This project aims to provide a **comprehensive learning experience** for beginners in game development and highlight how modular design principles can lead to clean, scalable, and fun games.

---

## ✨ Key Features

### 🎮 Core Gameplay
- Two-player (local multiplayer) and single-player (AI) modes  
- Smooth, physics-based ball motion using Unity’s Rigidbody system  
- Responsive paddle controls via keyboard inputs  
- Countdown timer and restart mechanism for game flow control  

### 🧠 Artificial Intelligence
- Simple yet effective AI logic that follows the ball’s Z-axis  
- Mimics human reaction delay for realistic difficulty  
- Introduces foundational AI movement concepts  

### 📊 Scoring & Game Flow
- Dynamic scoreboard that updates in real-time  
- Event-driven score tracking using **Unity Events**  
- Automatic reset and restart after each goal  
- Central game controller managing game states and transitions  

### 🎨 Cyberpunk Aesthetic
- Neon glow lighting and futuristic design theme  
- Dark environment with high-contrast visuals  
- Glowing materials for paddles, walls, and the ball  
- Particle effects (smoke trails, collision sparks) for polish  
- Looping ambient background music and sound effects  

---

## ⚙️ Technical Highlights

- Built using **Unity 3D Engine**  
- Written entirely in **C#** with modular, maintainable code  
- Applied **Single Responsibility Principle** for clean scripting  
- Frame-rate independent movement using `Time.deltaTime`  
- Lightweight **Box Colliders** for improved performance  
- Tagged game objects (Ball, Player, Wall) for efficient collision logic  
- Prefabs used for modularity and project organisation  
- Incremental testing and debugging after each major feature  

---

## 🧩 Project Architecture
CyberpunkPong/
├── Assets/
│   ├── Scripts/
│   │   ├── PlayerController.cs         # Controls player paddle movement
│   │   ├── AIController.cs             # Handles AI paddle movement and logic
│   │   ├── BallController.cs           # Controls ball physics, collisions, and scoring
│   │   ├── GameController.cs           # Manages game states, UI updates, and score system
│   │   └── UIManager.cs (optional)     # Handles menu UI, pause/restart, etc.
│   │
│   ├── Materials/                      # Cyberpunk-themed materials (neon glow, emissive)
│   ├── Models/                         # 3D assets for paddles, ball, arena
│   ├── Prefabs/                        # Prefab versions of paddles, ball, etc.
│   ├── Scenes/
│   │   └── MainScene.unity             # Main playable scene
│   ├── Audio/                          # Game sound effects, background music
│   └── UI/ (optional)                  # Menu buttons, HUD elements, fonts
│
├── ProjectSettings/                    # Unity-generated project configuration
├── Packages/                           # Unity package manager dependencies
├── .gitignore                          # To ignore cache/build/temp files
└── README.md                           # Project overview and usage guide



---

## 🧰 Tech Stack

- **Game Engine:** Unity 3D  
- **Programming Language:** C#  
- **Design Theme:** Cyberpunk (neon lights, dark contrast, futuristic glow)  
- **Assets:** Custom 3D models, particle systems, and audio  

---

## ▶️ How to Play

1. Clone the repository:  
   ```bash
   git clone https://github.com/<your-username>/CyberpunkPong.git
2. Open the project in Unity.

3.Load the MainScene and press Play.

4. Controls:

Player 1: W / S to move

Player 2: Up / Down Arrow

First to reach target score wins!

## 📚 Future Scope

🌐 Online multiplayer support

⚔️ Dynamic AI difficulty

💥 Power-ups and level progression

🧠 Advanced lighting and post-processing effects

## Conclusion

This project demonstrates how Unity can be used to create a complete, polished 3D game with modular code, rich visuals, and interactive gameplay — perfect for beginners exploring game development.

👨‍💻 Author

Aditya Bhavsar
📧 [adityabhavsar010@gmail.com] 📍 India
Siddhesh Jadhav
📧 [siddhesh55555jadhav@gmail.com] 📍 India
Chaitanya Patil
📧 [chaitanyapatil0707@gmail.com] 📍 India


