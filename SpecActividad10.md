# Especificación Técnica: Componente Actividad10.razor

## 1. Descripción General
El componente `Actividad10.razor` tiene como finalidad mostrar el estado visual y textual de un sistema a partir de un código numérico recibido como parámetro.

## 2. Parámetros del Componente
* **`CodigoEstado`** (`int`): Código numérico que representa el estado actual del sistema. Es un parámetro obligatorio (`[Parameter]`).

## 3. Lógica de Negocio
El componente evalúa el valor de `CodigoEstado` mediante un bloque de lógica C# (`switch`) para asignar las siguientes variables internas:

| Código de Estado (`CodigoEstado`) | Mensaje a Mostrar (`Mensaje`) | Color/Estilo (`ColorHex` / CSS) |
| :--- | :--- | :--- |
| **200** | Sistema Operacional | Verde (`#28a745` / `success`) |
| **404** | Recurso No Encontrado | Amarillo (`#ffc107` / `warning`) |
| **500** | Error Interno del Servidor | Rojo (`#dc3545` / `danger`) |
| **Cualquier otro** | Estado Desconocido | Gris (`#6c757d` / `secondary`) |

## 4. Estructura de Interfaz de Usuario (UI)
* Un contenedor principal (`div`) con un indicador visual de color (círculo/badge o fondo).
* Un texto dentro o al lado del indicador que despliega el mensaje correspondiente al código recibido.

## 5. Mantenibilidad
Las sentencias utilizadas se apegan al estándar de desarrollo de C# y Razor en Blazor WebAssembly / Server, empleando parámetros directos y directivas nativas `@code`.