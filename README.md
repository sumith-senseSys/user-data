# Unity PlayFab User Authentication Project

A Unity project implementing user authentication and account management using PlayFab services.

## 📋 Project Overview

This Unity project provides a complete user authentication system with PlayFab integration, including account creation, login, and profile management functionality.

## 🔧 Technical Specifications

- **Unity Version**: 6000.3.3f1
- **Render Pipeline**: Universal Render Pipeline (URP) 17.3.0
- **Input System**: New Input System 1.17.0
- **Backend Service**: PlayFab

## 🎮 Features

- User account creation
- User login/authentication
- Profile management
- PlayFab integration for backend services
- UI-based account management system

## 📦 Key Dependencies

- Unity 2D Animation (13.0.2)
- Unity Input System (1.17.0)
- Universal Render Pipeline (17.3.0)
- Unity UI (2.0.0)
- PlayFab SDK
- Visual Scripting (1.9.9)

## 🗂️ Project Structure

```
Assets/
├── PlayfabAccountUI/       # PlayFab account UI components
├── PlayFabSDK/             # PlayFab SDK files
├── PlayFabEditorExtensions/ # PlayFab editor tools
├── Scenes/                 # Unity scenes
├── Scripts/                # C# scripts
│   ├── UI/                # UI controllers
│   │   ├── UICreateAccount.cs
│   │   ├── UILoginAccount.cs
│   │   └── UIProfile.cs
│   ├── UserAccountManager.cs  # Main account management
│   └── UserProfile.cs      # User profile data
└── Settings/               # Project settings
```

## 🚀 Getting Started

### Prerequisites

- Unity Hub
- Unity Editor 6000.3.3f1 or compatible version
- PlayFab account and Title ID

### Installation

1. Clone this repository
2. Open the project in Unity Hub
3. Configure your PlayFab Title ID in the PlayFab settings
4. Open the main scene from `Assets/Scenes/`
5. Press Play to test the authentication system

## 🔐 PlayFab Setup

1. Create a free PlayFab account at [playfab.com](https://playfab.com)
2. Create a new title in your PlayFab dashboard
3. Copy your Title ID
4. In Unity, navigate to PlayFab settings and enter your Title ID

## 📝 Usage

### Creating an Account

The `UserAccountManager` singleton handles all account operations:

```csharp
UserAccountManager.instance.createAccount(email, password, username);
```

### User Login

Use the provided UI components or access the manager directly for authentication.

### Profile Management

User profiles are managed through the `UIProfile` component and stored via PlayFab's user data system.

## 🛠️ Development

### Scripts Overview

- **UserAccountManager.cs**: Singleton manager for PlayFab authentication
- **UserProfile.cs**: User profile data structure
- **UI Controllers**: Handle user interface interactions for account operations

## 📄 License

This project is provided as-is for educational and development purposes.

## 🤝 Contributing

Feel free to submit issues and enhancement requests.

## 📧 Support

For PlayFab-specific issues, refer to the [PlayFab Documentation](https://docs.microsoft.com/gaming/playfab/).

---

**Note**: Make sure to keep your PlayFab credentials secure and never commit them to version control.
