# Gym Assistant

**Gym Assistant** is an iOS workout tracking application built with **C# and .NET MAUI**. The project is designed to provide a structured way to create workout programs, manage training sessions, record notes, and track training progress from a mobile device.

The application follows the **MVVM architectural pattern**, separating the user interface, application logic, data models, navigation, and data persistence.

> **Status:** 🚧 Active development

---

## Overview

Gym Assistant is being developed as a practical companion for gym training. The goal is to bring workout planning, session tracking, notes, progress monitoring, and eventually health data into a single mobile application.

The project focuses on maintaining a clean architecture while supporting future expansion into **Apple Health integration** and **AI-assisted workout analysis**.

---

## Core Features

### Workout Programs
- Create custom workout programs
- Add exercises to a workout
- Configure sets, repetitions, working weight, and rest periods
- View and manage existing workout programs

### Workout Sessions
- Start workouts based on saved programs
- Track exercises and sets during a session
- Store workout session data
- Maintain workout history

### Training Journal
- Create general training notes
- View and edit existing notes
- Store notes locally for later reference

### Exercise Search
- Search for exercises while creating workout programs
- Retrieve exercise information through an external exercise API

### Progress Tracking
Planned progress tracking includes:

- Workout frequency
- Body weight history
- Training consistency
- Exercise performance over time
- Workout duration and other session metrics

---

## Architecture

The application follows the **MVVM (Model–View–ViewModel)** pattern.

```text
View
  ↓
ViewModel
  ↓
Services
  ↓
Models / Data
```

### Models

Represent the application's core data, including:

- Workout programs
- Workout exercises
- Workout sessions
- Workout history
- Notes

### ViewModels

Handle page state, commands, data binding, and communication between the user interface and application services.

### Services

Provide reusable application functionality including:

- Database operations
- Navigation
- Exercise API communication
- Workout-related data management

This separation keeps UI code independent from data access and core application logic.

---

## Project Structure

```text
Gym_application/
│
├── Models/          # Application data models
├── Pages/           # Views and ViewModels
├── Services/        # Database, navigation and API services
├── Helpers/         # Shared helper functionality
├── Resources/       # Images, fonts and application resources
├── Platforms/       # Platform-specific configuration
│
├── App.xaml
├── AppShell.xaml
├── MauiProgram.cs
└── gym_assistant.csproj
```

---

## Technologies

- **C#**
- **.NET MAUI**
- **XAML**
- **MVVM**
- **SQLite / Local Data Persistence**
- **REST API Integration**
- **iOS Development**
- **Object-Oriented Programming**
- **Git & GitHub**

---

## Development Roadmap

### Current Development

- Workout program creation and management
- Exercise configuration
- Local data persistence
- Workout session architecture
- Training journal
- Navigation and application structure

### Planned

- Active workout mode
- Set and repetition tracking
- Workout and rest timers
- Body weight tracking
- Progress charts and analytics
- Workout history improvements

### Future

- **Apple Health integration**
- Heart rate and activity data
- **AI-powered training assistant**
- Training history analysis
- AI-generated workout recommendations
- Personalized workout program generation

---

## UI / UX

The interface is designed specifically for mobile use during workouts, with an emphasis on **quick interaction, clear information hierarchy, and minimal distraction**.

The application uses a tab-based navigation structure to provide quick access to the main areas of the app, including workouts, progress, training notes, and the dashboard.

---

## Project Goals

This project is being developed both as a practical workout application and as an exploration of **mobile software architecture with .NET MAUI**.

Key development goals include:

- Applying MVVM in a larger mobile application
- Maintaining clear separation of responsibilities
- Designing reusable services and data models
- Implementing persistent local data storage
- Working with external APIs
- Building a native iOS-focused user experience
- Preparing the architecture for future health and AI integrations

---

## Current Status

Gym Assistant is currently under active development. Core architecture, workout program management, navigation, notes, data persistence, and exercise-related functionality are being developed and refined as the project progresses.

Additional workout tracking, analytics, Apple Health, and AI features will be introduced incrementally.
