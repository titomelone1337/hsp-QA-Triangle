# Trignometry MVC Application

This repository contains a C# console application developed to model and test triangle-related operations, such as calculating the area, perimeter, and determining the triangle type. The project follows the **MVC (Model-View-Controller)** design pattern for better structure and separation of concerns.

## 📁 Project Structure

- **DomainTest**: Contains the `Triangle` class (Model), responsible for the core logic and calculations.
- **Trignometry**: The main console application which uses the MVC pattern:
  - `Controller/`: Handles logic and connects the model and view.
  - `View/`: Displays output to the user.
  - `Program.cs`: Entry point of the application.
- **TrignometryTest**: Contains unit tests for the application.

## 🧠 Author

**Tiago Melo**  
Aluno do 3º ano de Engenharia Informática  
Este repositório foi desenvolvido como parte de um exercício prático, aplicando o padrão de arquitetura **MVC** em aplicações .NET.

## 🛠️ Technologies Used

- C# (.NET Framework)
- xUnit (for unit testing)
- Visual Studio 2022

## 🧪 Features

- Create different triangles with diff parameters
- Calculate the area and the perimeter
- Identify the triangle´s type(Equilátero, Isósceles, Escaleno)
- Unit tests for the required funcionalities

## 🚀 How to Run

1. Clone the repository:
   ```bash
   git clone https://github.com/titomelone1337/hsp-QA-Triangle.git
