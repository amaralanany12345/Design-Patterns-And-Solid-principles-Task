# Coffee Shop Management System

## Overview

This project is a **C# Console Application** that simulates a Coffee Shop Management System while demonstrating the implementation of **12 Design Patterns** and the **SOLID Principles**.

The system supports beverage creation, ingredient management, order processing, payment integration, notifications, validation pipelines, and customer discounts. The project was designed to showcase clean architecture, maintainability, extensibility, and object-oriented design best practices.

---

# Project Goals

* Apply all required Design Patterns in a meaningful way.
* Follow the five SOLID principles throughout the application.
* Demonstrate clean separation of concerns.
* Build a flexible and extensible coffee shop domain.
* Provide a complete end-to-end order workflow.

---

# Technologies

* C#
* .NET
* Object-Oriented Programming (OOP)
* Design Patterns
* SOLID Principles

---

### Solution  Structure

## Design Pattern Project 


# Domain Model

The Main Domain Models contains :

* IBeverage
* Coffee
* Espresso
* Latte
* Tea
* Order
* Shop Configuration


The system ships with pre-seeded data ** drinks and one customer for not complicated ** and demonstrates a complete order lifecycle.

---

# Design Patterns Implemented

## 1. Builder Pattern

### Purpose

Construct complex Coffee objects with many optional properties Using Builder pattern.

### Classes

* Coffee
* CoffeeBuilder

### Interfaces

* ICoffeeBuilder

### Benefits

* Readable object creation.
* Produces immutable Coffee instances.

---

## 2. Factory Method Pattern

### Purpose

Create drink families without tightly coupling client code to concrete classes.

### Classes

* DrinkServiceFactory
* EspressoDrink
* LatteDrink
* TeaDrink

###

* IDrink
* IDrinkFactory

### Benefits

* Supports Open/Closed Principle.
* Easy to add new drink families.

---

## 3. Abstract Factory Pattern

### Purpose

Create related ingredient families for different regions.

### Classes

* IIngredientFactory
* EuropeanIngredientFactory
* AmericanIngredientFactory

### Products

* IMilk
* IBeans

### Benefits

* Guarantees compatible ingredient sets.
* Region can be changed at the composition root only.

---

## 4. Singleton Pattern

### Purpose

Provide a single application-wide configuration instance.

### Class

* ShopConfiguration

### Stored Settings

* Tax Rate
* Currency
* Opening Hours

### Benefits

* Centralized configuration management.
* Thread-safe implementation using Lazy<T>.

---

## 5. Decorator Pattern

### Purpose

Add beverage features dynamically.

### Decorators

* MilkDecorator
* ExtraShotDecorator
* SyrupDecorator
* WhippedCreamDecorator

### Benefits

* Runtime customization.
* Avoids subclass explosion.

---

## 6. Adapter Pattern

### Purpose

Integrate a third-party payment gateway.

### Classes

* PaymentProcessorAdapterForLegacyPayment
* PaymentProcessorService

### Benefits

* Shields application from external API changes.
* Converts card numbers and payment formats internally.

---

## 7. Proxy Pattern

### Purpose

Delay expensive image loading until needed.

### Classes

* IImage
* RealImage
* ProxyImage

### Benefits

* Lazy loading.
* Improved performance.

---

## 8. Facade Pattern

### Purpose

Simplify order placement.

### Subsystems

* InventoryService
* PaymentServiceFacade
* NotificationService
* OrderServiceFacade

### Facade

* OrderFacade

### Benefits

* Single entry point.
* Reduced client complexity.

---

## 9. Strategy Pattern

### Purpose

Apply discounts dynamically.

### Strategies

* NoneDiscountStrategy
* PercentageOffStrategy
* BuyOneGetOneStrategy

### Benefits

* Eliminates conditional logic.
* Easily extensible.

---

## 10. Observer Pattern

### Purpose

Notify interested parties when order status changes.

### Observers

* CustomerAppObserver
* SmsObserver
* KitchenDisplayObserver

### Subjects

* OrderSubject

### Interfaces

* IObserver
* ISubject

### Benefits

* Loose coupling.
* New observers can be added without modifying Order.

---

## 11. Mediator Pattern

### Purpose

Coordinate communication between shop stations.

### Colleagues

* Station
* CashierStation
* BaristaStationStation
* PickupCounterStation

### Mediator

* OrderMediator

### Benefits

* Reduces direct dependencies.
* Simplifies communication flow.

---

## 12. Chain of Responsibility Pattern

### Purpose

Validate orders through a configurable pipeline.

### Handlers

* OrderHandler
* OrderStockValidator
* CustomerPaymentValidator
* AgeRestrictedValidator

### Benefits

* Reorderable validation flow.
* Easy to add new validation rules.

---

# SOLID Principles

## Single Responsibility Principle (SRP)

Each class has one reason to change.

Examples:

* PaymentService handles payments only.
* NotificationService handles notifications only.
* InventoryService handles stock management only.

---

## Open/Closed Principle (OCP)

The application is open for extension but closed for modification.

Examples:

* New discounts can be added without modifying existing code.
* New drink types can be introduced through Factory Method.

---

## Liskov Substitution Principle (LSP)

Implementations can be replaced by their abstractions without affecting correctness.

Examples:

* Any IDiscountStrategy.
* Any IPaymentProcessor.
* Any IBeverage.

---

## Interface Segregation Principle (ISP)

Small focused interfaces are used throughout the application.

Examples:

* IBeverage
* IPaymentProcessor
* IOrderObserver
* IImage

---

## Dependency Inversion Principle (DIP)

High-level modules depend on abstractions.

Examples:

* PaymentService depends on IPaymentProcessor.
* OrderFacade depends on abstractions rather than concrete implementations.

---

# Refactor Exercise

The project includes a refactored version of the provided OrderProcessor.

## Problems Identified

### SRP Violation

Original class handled:

* Validation
* Payment
* Logging
* File Operations
* Notifications

### OCP Violation

Adding a new payment method required modifying existing conditional logic.

### DIP Violation

The class directly depended on:

```csharp
Console
File
```


## Refactoring Solution

Introduced:

* PaymentProcessType
* LogginService
* SendMessageService
* INotifier

Result:

* Extensible payment system.
* Improved testability.
* Better separation of concerns.
* Dependency injection support.

---

# Author

Ammar Mostafa

Full Stack Developer (.NET & Angular)

---

# License

This project was created for educational purposes to demonstrate Design Patterns and SOLID Principles in C#.
