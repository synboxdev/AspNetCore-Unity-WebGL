# **AspNetCore Web Application + Unity WebGL**

## 📄 <b>Table of contents</b>

* [About](#about)
* [Technology stack](#technology-stack)
    * [Web app specifics](#web-app-specifics)
    * [Unity Engine specifics](#unity-engine-specifics)
* [Getting started](#getting-started)
    * [Prerequisites](#prerequisites)
    * [Getting the project](#getting-the-project)
* [Running the project](#running-the-project)
    * [CMD](#cmd)
    * [IDE Tooling](#ide-tooling)
    * [Docker](#docker)
* [Credits & Licensing](#credits--licensing)

## **About**

This repository is a small example of how **Unity WebGL** build could be incorporated and used within **ASP.NET Core web application** with MVC framework. 

Goal was to create *minimum viable product* of a ASP.NET Core web application, with bare minimum configuration and simple, straight to the point project structure.

## **Technology stack**

* #### [**C#**](https://learn.microsoft.com/en-us/dotnet/csharp/) / [**.NET 9**](https://dotnet.microsoft.com/en-us/download/dotnet/9.0)
* #### [**Visual Studio 2022**](https://visualstudio.microsoft.com/vs/) / [**Visual Studio Code**](https://code.visualstudio.com/)
* #### [**Unity Engine**](https://unity.com/)
* #### [**Git**](https://learn.microsoft.com/en-us/devops/develop/git/what-is-git) / [**Sourcetree**](https://www.sourcetreeapp.com/)
* #### [**Docker (Docker Desktop)**](https://www.docker.com/)

### **Web app specifics**

Using [**Visual Studio 2022**](https://visualstudio.microsoft.com/vs/), I've picked **ASP.NET Core Web App (Model-View-Controller)** as the [template](https://learn.microsoft.com/en-us/visualstudio/ide/creating-project-and-item-templates?view=vs-2022#visual-studio-templates) for this project.

### **Unity Engine specifics**

At the time of writing this, using [**Unity Hub (3.10.0)**](https://unity.com/unity-hub) and [**Unity Editor (6000.0.25f1)**](https://unity.com/products/unity-engine), I've picked [**'2D Platformer Microgame'**](https://learn.unity.com/project/2d-platformer-template) free project template, available during project creation in Unity Hub. Simple, lightweight sample project, which can be built into a WebGL.

The only settings that were adjusted during creation of the actual WebGL builds were the following (Read more [here](https://docs.unity3d.com/6000.0/Documentation/Manual/webgl-deploying.html)):

- **Decompression Fallback** (Determines how Unity processes downloaded files when the build runs in the browser) - **ENABLED** for all three builds.
- **Compression Format** - I've built the project with all three available compression formats - **'No compression'**, **'Brotli compression'** and **'Gzip compression'**.

## **Getting started**

### **Prerequisites**
- [**.NET 9 SDK**](https://dotnet.microsoft.com/en-us/download/dotnet/9.0)
- [**Docker**](https://www.docker.com/)
- IDE of your choice. I use [**Visual Studio**](https://visualstudio.microsoft.com/downloads/) / [**Visual Studio Code**](https://code.visualstudio.com/)
- [**Git**](https://git-scm.com/downloads) (Optional, if you want to use it to clone the repository)

### **Getting the project**
There are multiple ways of doing this. Here's two:
1. <strong>Method 1</strong> - run the following command using a CMD terminal in an empty directory:

   ```bash
   git clone https://github.com/synboxdev/AspNetCore-Unity-WebGL.git
   ```
Afterwards, the project's repository will be downloaded to the directory inside of which you've ran this command.

2. <strong>Method 2</strong> - Downloading zipped repository and extracting it locally. [**Download**](https://github.com/synboxdev/AspNetCore-Unity-WebGL/archive/refs/heads/main.zip) zipped repository, and extract the files to a folder of your choosing.

## **Running the project**

Once you've retrieved the repository to your local machine, before running the following, do the following:
1. Build the solution to restore dependencies.
2. Start the project with one of the methods described below

### **CMD**

You start the project locally, by executing the following command in the root directory of the solution

   ```bash
   dotnet run Bacchus
   ```

And then open the following URL in your browser - `https://localhost:7185` or `http://localhost:5288`

### **IDE Tooling**

If you are using Visual Studio - you can simply start the project with the GUI interface - navigate to **'Debug'** tab -> **'Start without debugging'**. Or use the default shortcut of **CTRL + F5**.

### **Docker**

Open up a command-line terminal in the root directory of the solution, and run the two following commands:

   ```bash
   docker build -t bacchus .
   docker run -p 443:8080 bacchus
   ```
Once that's done - the project should be up and running in a newly created docker container, accessible via browser on `http://localhost:443`

## **Credits & Licensing**

This project is licensed under the [MIT License](https://en.wikipedia.org/wiki/MIT_License).

For any and all inquires, feel free to [contact me](https://github.com/synboxdev).