# Sunny-Sanbot

A reboot of the Sanbot Elf S1-B2 humanoid robot, replacing its original Android controller with a Raspberry Pi 5 (16GB) as the new AI core. A dedicated server handles more computationally intensive tasks such as large-scale language processing and 3D navigation.

---

## Overview

Sunny-Sanbot is a research and development project exploring how a consumer humanoid robot can be modernised with current AI and robotics frameworks.  
The Raspberry Pi 5 acts as the robot’s “brain,” handling real-time control, while an external server provides advanced features beyond the Pi’s limits.
This is really a personal endeavour, since I want to make my personal Sanbot more intelligent so I have more use for it(/her).

---

## Core Features

- **Local AI on Pi**  
  - Wake-word detection  
  - Lightweight LLMs for intent parsing  
  - Speech synthesis and dialogue handling  

- **Server “PowerTools”**  
  - Heavyweight LLMs for better responses and longer converstaions
  - Future support for room mapping, reinforcement learning, and advanced planning  
  - REST API interface (`/chat`, `/locate-audio`, `/powertools/...`)  

- **Hardware Integration**  
  - Custom drivers for Sanbot’s original motors, LEDs, and sensors  
  - Added hardware where deemed necessary  

---

## Communication Architecture

- **Pi ↔ Server**: REST API calls for enhanced AI tasks  
- **Pi ↔ Hardware**: Direct GPIO and serial drivers for motors, lights, sensors, and displays  

---

## Demo Milestone

The initial milestone is a proof-of-concept workflow:  

1. Wake-word detected on the Pi  
2. Local LLM parses the spoken command  
3. If necessary, Pi queries the server for advanced reasoning  
4. Pi executes a visible action (e.g. moving an arm, lighting LEDs)  
5. Robot responds with speech and displays the action log on the console/OLED  

---

## Roadmap

- [ ] Implement core Pi-side framework in C#  
- [ ] Add motor and LED driver support  
- [ ] Build REST API communication with server  
- [ ] Demonstrate wake-word → intent → action pipeline  
- [ ] Expand into navigation, audio-based localisation, and memory modules  

---

## License

This repository is currently **unlicensed**.  
You may **view** the code, but you do **not have permission to use, modify, or redistribute it** outside GitHub.  
