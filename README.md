# 🍼 Baby Class - Constructor Practice

This project demonstrates the implementation of the `Baby` class with two constructors, properties, and their use cases. The aim is to learn about constructors in C# and how they initialize object properties.

---

## ✨ Project Features

### 📦 Baby Class Properties
- **`BirthDate`**: Represents the birth date of the baby (type: `DateTime`).
- **`Name`**: Represents the first name of the baby (type: `string`).
- **`Surname`**: Represents the last name of the baby (type: `string`).

---

### 🚀 Constructors
1. **Default Constructor**:
   - No parameters.
   - Initializes `BirthDate` to `DateTime.MinValue`.
   - Prints the message `"Ingaaaa"` to the console when a baby object is created.

2. **Parameterized Constructor**:
   - Takes `Name` and `Surname` as parameters.
   - Sets these values during object creation.
   - Initializes `BirthDate` to `DateTime.MinValue`.
   - Prints the message `"Ingaaaa"` to the console when a baby object is created.

---

## 🛠️ Usage Example

The program creates two baby objects using both constructors and prints their details to the console.

### 🧸 Example Objects:
1. **Baby 1** (Created with Default Constructor):
   - `BirthDate`: `DateTime.MinValue` (default value).
   - `Name`: Empty or uninitialized.
   - `Surname`: Empty or uninitialized.
   - Console Output: `"Ingaaaa"`

2. **Baby 2** (Created with Parameterized Constructor):
   - `Name`: Provided during initialization.
   - `Surname`: Provided during initialization.
   - `BirthDate`: `DateTime.MinValue` (default value).
   - Console Output: `"Ingaaaa"`

### 📟 Console Output Example:
```plaintext
Baby 1 Details:
Name: 
Surname: 
Birth Date: 01/01/0001 00:00:00
Ingaaaa

Baby 2 Details:
Name: Furkancan
Surname: Yılmaz
Birth Date: 01/01/0001 00:00:00
Ingaaaa
