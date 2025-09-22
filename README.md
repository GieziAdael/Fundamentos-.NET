# CsBasesCurso 🎯

Este proyecto está desarrollado en **.NET** como parte de mi aprendizaje en C#.  
Incluye conceptos fundamentales de programación orientada a objetos, patrones de diseño y buenas prácticas que forman la base para un desarrollador **.NET Junior**.

---

## 📌 Contenido del proyecto

- **POO en C#**: uso de clases, objetos, interfaces, herencia y encapsulación.  
- **Patrón Adaptador**: implementación para transformar entidades en DTOs.  
- **Inyección de Dependencias**: separación de responsabilidades mediante interfaces.  
- **Programación Asíncrona**: uso de `async` y `await`.  
- **DTOs (Data Transfer Objects)**: para separar la lógica de negocio de la representación de datos.  

---

## 🚀 Tecnologías usadas
- [C#](https://learn.microsoft.com/es-es/dotnet/csharp/)
- [.NET 6/7](https://dotnet.microsoft.com/)  
- Git & GitHub  

---

## 📂 Estructura del proyecto
```
CsBasesCurso/
│── Fundamentals/         # Carpeta con ejemplos de fundamentos
│── Program.cs            # Punto de entrada del programa
│── CsBasesCurso.csproj   # Configuración del proyecto
```

---

## ▶️ Cómo ejecutar el proyecto
1. Clonar el repositorio:
   ```bash
   git clone https://github.com/tu-usuario/CsBasesCurso.git
   ```
2. Entrar al directorio:
   ```bash
   cd CsBasesCurso
   ```
3. Ejecutar con .NET:
   ```bash
   dotnet run
   ```

---

## 📖 Ejemplos de uso
```csharp
// Creación de un producto
var laptop = new ClassProduct("Laptop HP", 9900.50m);

// Uso del patrón adaptador
var productDto = ProductAdapter.ToDto(laptop);

// Inyección de dependencias
ILabelService labelService = new ClassLabelService();
var manager = new ProductManager(labelService);
```

---

## ✨ Objetivo
Este proyecto es un **compendio de conceptos base en .NET** para demostrar:  
✔️ Conocimiento de POO y patrones  
✔️ Aplicación de buenas prácticas  
✔️ Preparación para un puesto **Junior .NET Developer**

---

## 📌 Próximos pasos
- Crear una API RESTful con CRUD.  
- Integrar Entity Framework Core.  
- Aprender sobre autenticación con JWT e Identity.  

---

👨‍💻 Desarrollado por [GieziAdael](https://github.com/tu-usuario)
